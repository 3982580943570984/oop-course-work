using CourseWork.Entities;
using CourseWork.Helpers;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Forms.ForTransports;

public partial class AddTransportForm : Form
{
    public AddTransportForm() => InitializeComponent();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.autoParkContext.Drivers.Load();
        DriverBindingSource.DataSource = MainForm.autoParkContext.Drivers.Local.ToBindingList();

        MainForm.autoParkContext.Routes.Load();
        RouteBindingSource.DataSource = MainForm.autoParkContext.Routes.Local.ToBindingList();

        ComboBoxDriver.DisplayMember = "FirstName";

        ComboBoxFirstLetter.SelectedIndex = 0;
        ComboBoxSecondLetter.SelectedIndex = 0;
        ComboBoxThirdLetter.SelectedIndex = 0;
    }

    private async void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        TransportService transportService = new(MainForm.autoParkContext);

        try
        {
            var driver = ComboBoxDriver.SelectedItem as Driver;
            var route = ComboBoxRoute.SelectedItem as Route;

            var transport = new Transport
            {
                Model = TextBoxModel.Text,
                LicensePlate = $"{ComboBoxFirstLetter.Text}{NumericUpDownLicensePlateNumber.Value:000}{ComboBoxSecondLetter.Text}{ComboBoxThirdLetter.Text}",
                Capacity = (int)NumericUpDownCapacity.Value,
                LastMaintenanceDate = DateTimePickerMaintenanceDate.Value,
                Mileage = (double)NumericUpDownMileage.Value,
                Driver = driver,
                Route = route
            };

            await transportService.AddTransportAsync(transport);

            MessageBox.Show("Транспорт успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось добавить транспорт: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput() => !string.IsNullOrWhiteSpace(TextBoxModel.Text);

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        var transportParameters = TransportGenerator.Generate();

        TextBoxModel.Text = transportParameters.Item1;
        ComboBoxFirstLetter.SelectedItem = transportParameters.Item2[0];
        NumericUpDownLicensePlateNumber.Value = int.Parse(transportParameters.Item2[1]);
        ComboBoxSecondLetter.SelectedItem = transportParameters.Item2[2];
        ComboBoxThirdLetter.SelectedItem = transportParameters.Item2[3];
        NumericUpDownCapacity.Value = transportParameters.Item3;
        DateTimePickerMaintenanceDate.Value = transportParameters.Item4;
        NumericUpDownMileage.Value = transportParameters.Item5;
    }

    /// <summary>
    /// Обработчик нажатия на кнопку очистки полей формы
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxModel.Clear();
        ComboBoxFirstLetter.ResetText();
        NumericUpDownLicensePlateNumber.Value = NumericUpDownLicensePlateNumber.Minimum;
        ComboBoxSecondLetter.ResetText();
        ComboBoxThirdLetter.ResetText();
        NumericUpDownCapacity.Value = NumericUpDownCapacity.Minimum;
        DateTimePickerMaintenanceDate.ResetText();
        NumericUpDownMileage.Value = NumericUpDownMileage.Minimum;
        ComboBoxDriver.ResetText();
        ComboBoxRoute.ResetText();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку выхода из приложения
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonExit_Click(object sender, EventArgs e) => Close();

    private void TextBoxModel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxModel.Text))
            ErrorProvider.SetError(TextBoxModel, "Некорректная модель автомобиля");
    }
}
