using CourseWork.Entities;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Forms.ForRoutes;

public partial class UpdateRouteForm : Form
{
    private readonly Route _route = new();

    public UpdateRouteForm() => InitializeComponent();

    public UpdateRouteForm(Route route) : this() => _route = route;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        MainForm.autoParkContext.Transports.Load();
        TransportBindingSource.DataSource = MainForm.autoParkContext.Transports.Local.ToBindingList();

        TextBoxName.Text = _route.Name;
        NumericUpDownDistance.Value = _route.Distance;
        TextBoxStartLocation.Text = _route.StartLocation;
        TextBoxEndLocation.Text = _route.EndLocation;
        DateTimePickerStartTime.Value = _route.StartTime;
        DateTimePickerEndTime.Value = _route.EndTime;

        var transports = _route.Transports.Cast<Transport>().ToArray();
        var selectedIndices = transports.Select(ListBoxTransports.Items.IndexOf).ToArray();
        foreach (var indice in selectedIndices)
            ListBoxTransports.SetSelected(indice, true);
    }

    private async void ButtonUpdate_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
        {
            MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _route.Name = TextBoxName.Text;
        _route.Distance = (int)NumericUpDownDistance.Value;
        _route.StartLocation = TextBoxStartLocation.Text;
        _route.EndLocation = TextBoxEndLocation.Text;
        _route.StartTime = DateTimePickerStartTime.Value;
        _route.EndTime = DateTimePickerEndTime.Value;
        _route.Transports = ListBoxTransports.SelectedItems.Cast<Transport>().ToList();

        RouteService routeService = new(MainForm.autoParkContext);
        try
        {
            await routeService.UpdateRouteAsync(_route);

            MessageBox.Show("Маршрут успешно изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось изменить маршрут: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput() => !string.IsNullOrWhiteSpace(TextBoxName.Text)
                                && !string.IsNullOrWhiteSpace(TextBoxStartLocation.Text)
                                && !string.IsNullOrWhiteSpace(TextBoxEndLocation.Text);

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
