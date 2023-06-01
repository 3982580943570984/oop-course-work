using CourseWork.Entities;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Forms.ForTransports;

public partial class UpdateTransportForm : Form
{
    private readonly Transport _transport = new();

    public UpdateTransportForm() => InitializeComponent();

    public UpdateTransportForm(Transport transport) : this() => _transport = transport;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.autoParkContext.Drivers.Load();
        DriverBindingSource.DataSource = MainForm.autoParkContext.Drivers.Local.ToBindingList();

        MainForm.autoParkContext.Routes.Load();
        RouteBindingSource.DataSource = MainForm.autoParkContext.Routes.Local.ToBindingList();

        TextBoxModel.Text = _transport.Model;
        ComboBoxFirstLetter.SelectedText = _transport.LicensePlate[0].ToString();
        NumericUpDownLicensePlateNumber.Value = int.Parse(_transport.LicensePlate.Substring(1, 3));
        ComboBoxSecondLetter.SelectedText = _transport.LicensePlate[4].ToString();
        ComboBoxThirdLetter.SelectedText = _transport.LicensePlate[5].ToString();
        NumericUpDownCapacity.Value = _transport.Capacity;
        DateTimePickerMaintenanceDate.Value = _transport.LastMaintenanceDate;
        NumericUpDownMileage.Value = int.Parse(_transport.Mileage.ToString());
        ComboBoxDriver.SelectedItem = _transport.Driver;
        ComboBoxRoute.SelectedItem = _transport.Route;
    }

    private async void ButtonUpdate_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _transport.Model = TextBoxModel.Text;
        _transport.LicensePlate = $"{ComboBoxFirstLetter.Text}{NumericUpDownLicensePlateNumber.Value:000}{ComboBoxSecondLetter.Text}{ComboBoxThirdLetter.Text}";
        _transport.Capacity = (int)NumericUpDownCapacity.Value;
        _transport.LastMaintenanceDate = DateTimePickerMaintenanceDate.Value;
        _transport.Mileage = (double)NumericUpDownMileage.Value;
        _transport.Driver = ComboBoxDriver.SelectedItem as Driver;
        _transport.Route = ComboBoxRoute.SelectedItem as Route;

        TransportService transportService = new(MainForm.autoParkContext);
        try
        {
            await transportService.UpdateTransportAsync(_transport);

            MessageBox.Show("Транспорт успешно изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось изменить транспорт: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput() => !string.IsNullOrWhiteSpace(TextBoxModel.Text);

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
