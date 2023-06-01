using CourseWork.Entities;
using CourseWork.Helpers;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Forms.ForRoutes;

public partial class AddRouteForm : Form
{
    public AddRouteForm() => InitializeComponent();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.autoParkContext.Transports.Load();
        TransportBindingSource.DataSource = MainForm.autoParkContext.Transports.Local.ToBindingList();
    }

    private async void ButtonAdd_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        RouteService routeService = new(MainForm.autoParkContext);

        try
        {
            var route = new Route
            {
                Name = TextBoxName.Text,
                Distance = (int)NumericUpDownDistance.Value,
                StartLocation = TextBoxStartLocation.Text,
                EndLocation = TextBoxEndLocation.Text,
                StartTime = DateTimePickerStartTime.Value,
                EndTime = DateTimePickerEndTime.Value,
                Transports = ListBoxTransports.SelectedItems.Cast<Transport>().ToList(),
                Drivers = ListBoxTransports.SelectedItems.Cast<Transport>().Select(t => t.Driver).Where(d => d != null).ToList(),
            };

            await routeService.AddRouteAsync(route);

            MessageBox.Show("Транспорт успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось добавить транспорт: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput() => !string.IsNullOrWhiteSpace(TextBoxName.Text)
                                    && !string.IsNullOrWhiteSpace(TextBoxStartLocation.Text)
                                    && !string.IsNullOrWhiteSpace(TextBoxEndLocation.Text);

    private void ButtonGenerate_Click(object sender, EventArgs e)
    {
        var routeParameters = RouteGenerator.Generate();

        TextBoxName.Text = routeParameters.Item1;
        TextBoxStartLocation.Text = routeParameters.Item2;
        TextBoxEndLocation.Text = routeParameters.Item3;
        NumericUpDownDistance.Value = (decimal)routeParameters.Item4;
    }

    private void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxName.Clear();
        NumericUpDownDistance.Value = NumericUpDownDistance.Minimum;
        TextBoxStartLocation.Clear();
        TextBoxEndLocation.Clear();
        DateTimePickerStartTime.ResetText();
        DateTimePickerEndTime.ResetText();
        ListBoxTransports.ClearSelected();
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();

    private void TextBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            ErrorProvider.SetError(TextBoxName, "Некорректное название маршрута");
    }

    private void TextBoxStartLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxStartLocation.Text))
            ErrorProvider.SetError(TextBoxStartLocation, "Некорректная начальная остановка маршрута");
    }

    private void TextBoxEndLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TextBoxEndLocation.Text))
            ErrorProvider.SetError(TextBoxEndLocation, "Некорректная конечная остановка маршрута");
    }
}
