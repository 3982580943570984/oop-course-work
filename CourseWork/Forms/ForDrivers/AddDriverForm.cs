using CourseWork.Entities;
using CourseWork.Helpers;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CourseWork;

public partial class AddDriverForm : Form
{
    public AddDriverForm() => InitializeComponent();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.autoParkContext.Transports.Load();
        TransportBindingSource.DataSource = MainForm.autoParkContext.Transports.Local.ToBindingList();

        MainForm.autoParkContext.Routes.Load();
        RouteBindingSource.DataSource = MainForm.autoParkContext.Routes.Local.ToBindingList();
    }

    private async void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        DriverService driverService = new(MainForm.autoParkContext);

        try
        {
            Transport? transport = ComboBoxTransport.SelectedItem as Transport;

            var driver = new Driver
            {
                FirstName = TextBoxFirstName.Text,
                LastName = TextBoxLastName.Text,
                Age = (int)NumericUpDownAge.Value,
                DrivingExperience = (int)NumericUpDownDrivingExperience.Value,
                Transport = transport,
                Route = transport?.Route,
            };

            await driverService.AddDriverAsync(driver);

            MessageBox.Show("Водитель успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось добавить водителя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianName();

    [GeneratedRegex("^[А-ЯЁ][а-яё]*(-[А-ЯЁ][а-яё]*)?$")]
    private static partial Regex RegexRussianSurname();

    private bool ValidateInput() => RegexRussianName().IsMatch(TextBoxFirstName.Text)
                                    && RegexRussianSurname().IsMatch(TextBoxLastName.Text);

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        var driverParameters = DriverGenerator.Generate();

        TextBoxFirstName.Text = driverParameters.Item1;
        TextBoxLastName.Text = driverParameters.Item2;
        NumericUpDownAge.Value = driverParameters.Item3;
        NumericUpDownDrivingExperience.Value = driverParameters.Item4;
    }

    /// <summary>
    /// Обработчик нажатия на кнопку очистки полей формы
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxFirstName.Clear();
        TextBoxLastName.Clear();
        NumericUpDownAge.Value = NumericUpDownAge.Minimum;
        NumericUpDownDrivingExperience.Value = NumericUpDownDrivingExperience.Minimum;
        ComboBoxTransport.ResetText();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку выхода из приложения
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonExit_Click(object sender, EventArgs e) => Close();

    private void TextBoxFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!RegexRussianName().IsMatch(TextBoxFirstName.Text))
            ErrorProvider.SetError(TextBoxFirstName, "Некорректное имя водителя");
    }

    private void TextBoxLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (!RegexRussianName().IsMatch(TextBoxLastName.Text))
            ErrorProvider.SetError(TextBoxLastName, "Некорректная фамилия водителя");
    }
}
