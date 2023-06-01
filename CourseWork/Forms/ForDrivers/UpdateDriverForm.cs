using CourseWork.Entities;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CourseWork.Forms.ForTransports;

public partial class UpdateDriverForm : Form
{
    private readonly Driver _driver = new();

    public UpdateDriverForm() => InitializeComponent();

    public UpdateDriverForm(Driver driver) : this() => _driver = driver;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.autoParkContext.Transports.Load();
        TransportBindingSource.DataSource = MainForm.autoParkContext.Transports.Local.ToBindingList();

        TextBoxFirstName.Text = _driver.FirstName;
        TextBoxLastName.Text = _driver.LastName;
        NumericUpDownAge.Value = _driver.Age;
        NumericUpDownDrivingExperience.Value = _driver.DrivingExperience;
        ComboBoxTransport.SelectedItem = _driver.Transport;
    }

    private async void ButtonUpdate_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _driver.FirstName = TextBoxFirstName.Text;
        _driver.LastName = TextBoxLastName.Text;
        _driver.Age = (int)NumericUpDownAge.Value;
        _driver.DrivingExperience = (int)NumericUpDownDrivingExperience.Value;
        _driver.Transport = ComboBoxTransport.SelectedItem as Transport;

        DriverService driverService = new(MainForm.autoParkContext);
        try
        {
            await driverService.UpdateDriverAsync(_driver);

            MessageBox.Show("Водитель успешно изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось изменить водителя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianName();

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianSurname();

    private bool ValidateInput() => RegexRussianName().IsMatch(TextBoxFirstName.Text)
                                    && RegexRussianSurname().IsMatch(TextBoxLastName.Text);

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
