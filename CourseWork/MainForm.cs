using CourseWork.Contexts;
using CourseWork.Entities;
using CourseWork.Forms.ForDrivers;
using CourseWork.Forms.ForMain;
using CourseWork.Forms.ForRoutes;
using CourseWork.Forms.ForTransports;
using CourseWork.Services;
using Microsoft.EntityFrameworkCore;

namespace CourseWork;

public partial class MainForm : Form
{
    /// <summary>
    /// Контекст базы данных автопарка
    /// </summary>
    public static readonly AutoParkContext autoParkContext = new();

    /// <summary>
    /// Конструктор класса MainForm
    /// </summary>
    public MainForm() => InitializeComponent();

    /// <summary>
    /// Метод OnLoad
    /// </summary>
    /// <param name="e">Аргументы события</param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        autoParkContext.Database.EnsureDeleted();
        autoParkContext.Database.EnsureCreated();

        autoParkContext.Drivers.Load();
        DriverBindingSource.DataSource = autoParkContext.Drivers.Local.ToBindingList();
        UpdateDriverSearchTypes();

        autoParkContext.Transports.Load();
        TransportBindingSource.DataSource = autoParkContext.Transports.Local.ToBindingList();
        UpdateTransportSearchTypes();

        autoParkContext.Routes.Load();
        RouteBindingSource.DataSource = autoParkContext.Routes.Local.ToBindingList();
        UpdateRouteSearchTypes();

        AuthorInfoForm authorInfoForm = new();
        authorInfoForm.ShowDialog();
    }

    private void UpdateDriverSearchTypes()
    {
        ComboBoxDriversSearchTypes.Items.Clear();
        foreach (DataGridViewColumn column in DataGridViewDrivers.Columns)
            if (column.Visible)
                ComboBoxDriversSearchTypes.Items.Add(column.HeaderText);
        ComboBoxDriversSearchTypes.SelectedIndex = 0;
    }

    private void UpdateTransportSearchTypes()
    {
        ComboBoxTransportSearchTypes.Items.Clear();
        foreach (DataGridViewColumn column in DataGridViewTransportes.Columns)
            if (column.Visible)
                ComboBoxTransportSearchTypes.Items.Add(column.HeaderText);
        ComboBoxTransportSearchTypes.SelectedIndex = 0;
    }

    private void UpdateRouteSearchTypes()
    {
        ComboBoxRoutesSearchTypes.Items.Clear();
        foreach (DataGridViewColumn column in DataGridViewRoutes.Columns)
            if (column.Visible)
                ComboBoxRoutesSearchTypes.Items.Add(column.HeaderText);
        ComboBoxRoutesSearchTypes.SelectedIndex = 0;
    }

    /// <summary>
    /// Обработчик нажатия на кнопку добавления водителя
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonAddDriver_Click(object sender, EventArgs e)
    {
        AddDriverForm addDriverForm = new();
        addDriverForm.ShowDialog();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку изменения информации о водителе
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonUpdateDriver_Click(object sender, EventArgs e)
    {
        if (DriverBindingSource.Current != null)
        {
            Driver currentDriver = DriverBindingSource.Current as Driver;

            UpdateDriverForm updateDriverForm = new(currentDriver);
            updateDriverForm.ShowDialog();

            DataGridViewDrivers.Refresh();
        }
        else
        {
            MessageBox.Show("Выберите водителя для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия на кнопку удаления выбранных водителей
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private async void ButtonDeleteSelectedDrivers_Click(object sender, EventArgs e)
    {
        if (DataGridViewDrivers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите водителей для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Создаем сервис для удаления водителей
        DriverService driverService = new(autoParkContext);

        string deletedDriversIds = "";

        // Проходимся по каждой выбранной строке и удаляем соответствующего водителя
        foreach (DataGridViewRow selectedRow in DataGridViewDrivers.SelectedRows)
        {
            int driverId = (int)selectedRow.Cells[0].Value;

            try
            {
                await driverService.DeleteDriverAsync(driverId);

                // Если удаление прошло успешно, добавляем ID удаленного водителя в строку deletedDriversIds
                if (deletedDriversIds == "")
                    deletedDriversIds = driverId.ToString();
                else
                    deletedDriversIds += ", " + driverId.ToString();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при удалении водителя, выводимсообщение с ошибкой
                string errorMessage = $"Не удалось удалить водителя с ID {driverId}: {ex.Message}";
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Создаем сообщение об успешном выполнении операции и показываем его, используя список удаленных ID водителей
        string successMessage = $"Удалены водители с ID: {deletedDriversIds}";
        MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Обработчик нажатия на кнопку настройки фильтрации водителей
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonFilterDrivers_Click(object sender, EventArgs e)
    {
        FilterDriverForm filterDriverForm = new(DataGridViewDrivers);
        filterDriverForm.ShowDialog();

        /*UpdateDriverSearchTypes();*/
    }

    /// <summary>
    /// Обработчик нажатия на кнопку добавления транспорта
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonAddTransport_Click(object sender, EventArgs e)
    {
        AddTransportForm addTransportForm = new();
        addTransportForm.ShowDialog();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку обновления информации о транспорте
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonUpdateTransport_Click(object sender, EventArgs e)
    {
        if (TransportBindingSource.Current != null)
        {
            Transport currentTransport = TransportBindingSource.Current as Transport;

            UpdateTransportForm updateTransportForm = new(currentTransport);
            updateTransportForm.ShowDialog();

            DataGridViewTransportes.Refresh();
        }
        else
        {
            MessageBox.Show("Выберите транспорт для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия на кнопку удаления выбранных транспортов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private async void ButtonDeleteSelectedTransportes_Click(object sender, EventArgs e)
    {
        if (DataGridViewTransportes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите транспорт для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Создаем сервис для удаления транспорта
        TransportService transportService = new(autoParkContext);

        string deletedTransportsIds = "";

        // Проходимся по каждой выбранной строке и удаляем соответствующий транспорт
        foreach (DataGridViewRow selectedRow in DataGridViewTransportes.SelectedRows)
        {
            int transportId = (int)selectedRow.Cells[0].Value;

            try
            {
                await transportService.DeleteTransportAsync(transportId);

                // Если удаление прошло успешно, добавляем ID удаленного транспорта в строку deletedDriversIds
                if (deletedTransportsIds == "")
                    deletedTransportsIds = transportId.ToString();
                else
                    deletedTransportsIds += ", " + transportId.ToString();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при удалении транспорта, выводим сообщение с ошибкой
                string errorMessage = $"Не удалось удалить транспорт с ID {transportId}: {ex.Message}";
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Создаем сообщение об успешном выполнении операции и показываем его, используя список удаленных ID транспортов
        string successMessage = $"Удалены транспорты с ID: {deletedTransportsIds}";
        MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Обработчик нажатия на кнопку фильтрации транспортов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonFilterTransportes_Click(object sender, EventArgs e)
    {
        FilterTransportForm filterTransportForm = new(DataGridViewTransportes);
        filterTransportForm.ShowDialog();

        /*UpdateTransportSearchTypes();*/
    }

    /// <summary>
    /// Обработчик нажатия на кнопку добавления маршрута
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonAddRoute_Click(object sender, EventArgs e)
    {
        AddRouteForm addRouteForm = new();
        addRouteForm.ShowDialog();
    }

    /// <summary>
    /// Обработчик нажатия на кнопку обновления информации о маршруте
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonUpdateRoute_Click(object sender, EventArgs e)
    {
        if (RouteBindingSource.Current != null)
        {
            Route currentRoute = RouteBindingSource.Current as Route;

            UpdateRouteForm updateRouteForm = new(currentRoute);
            updateRouteForm.ShowDialog();

            DataGridViewRoutes.Refresh();
        }
        else
        {
            MessageBox.Show("Выберите маршрут для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Обработчик нажатия на кнопку удаления выбранных маршрутов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private async void ButtonDeleteRoutes_Click(object sender, EventArgs e)
    {
        if (DataGridViewRoutes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите маршруты для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Создаем сервис для удаления маршрута
        RouteService routeService = new(autoParkContext);

        string deletedRotuesIds = "";

        // Проходимся по каждой выбранной строке и удаляем соответствующий маршрут
        foreach (DataGridViewRow selectedRow in DataGridViewRoutes.SelectedRows)
        {
            int routeId = (int)selectedRow.Cells[0].Value;

            try
            {
                await routeService.DeleteRouteAsync(routeId);

                // Если удаление прошло успешно, добавляем ID удаленного маршрута в строку deletedDriversIds
                if (deletedRotuesIds == "")
                    deletedRotuesIds = routeId.ToString();
                else
                    deletedRotuesIds += ", " + routeId.ToString();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при удалении маршрута, выводим сообщение с ошибкой
                string errorMessage = $"Не удалось удалить маршрут с ID {routeId}: {ex.Message}";
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Создаем сообщение об успешном выполнении операции и показываем его, используя список удаленных ID маршрутов
        string successMessage = $"Удалены маршруты с ID: {deletedRotuesIds}";
        MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// Обработчик нажатия на кнопку фильтрации маршрутов
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonFilterRoutes_Click(object sender, EventArgs e)
    {
        FilterRouteForm filterRouteForm = new(DataGridViewRoutes);
        filterRouteForm.ShowDialog();

        /*UpdateRouteSearchTypes();*/
    }

    /// <summary>
    /// Обработчик нажатия на кнопку выхода из приложения
    /// </summary>
    /// <param name="sender">Отправитель события</param>
    /// <param name="e">Аргументы события</param>
    private void ButtonExit_Click(object sender, EventArgs e) => Application.Exit();

    private void TextBoxDriversSearchValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Enter)
            return;

        string searchText = TextBoxDriversSearchValue.Text.ToLower();
        CurrencyManager currencyManager = (CurrencyManager)BindingContext[DataGridViewDrivers.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in DataGridViewDrivers.Rows)
        {
            row.Visible = false;

            DataGridViewCell searchCell = row.Cells[ComboBoxDriversSearchTypes.SelectedIndex];
            if (searchCell != null && searchCell.Value.ToString().ToLower().Contains(searchText))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
        e.Handled = true;
    }

    private void TextBoxTransportsSearchValues_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Enter)
            return;

        string searchText = TextBoxTransportsSearchValues.Text.ToLower();
        CurrencyManager currencyManager = (CurrencyManager)BindingContext[DataGridViewTransportes.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in DataGridViewTransportes.Rows)
        {
            row.Visible = false;

            DataGridViewCell searchCell = row.Cells[ComboBoxTransportSearchTypes.SelectedIndex];
            if (searchCell != null && searchCell.Value.ToString().ToLower().Contains(searchText))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
        e.Handled = true;
    }

    private void TextBoxRoutesSearchValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Enter)
            return;

        string searchText = TextBoxRoutesSearchValue.Text.ToLower();
        CurrencyManager currencyManager = (CurrencyManager)BindingContext[DataGridViewRoutes.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in DataGridViewRoutes.Rows)
        {
            row.Visible = false;

            DataGridViewCell searchCell = row.Cells[ComboBoxRoutesSearchTypes.SelectedIndex];
            if (searchCell != null && searchCell.Value.ToString().ToLower().Contains(searchText))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
        e.Handled = true;
    }
}
