namespace CourseWork.Forms.ForTransports;

public partial class FilterTransportForm : Form
{
    private readonly DataGridView _dataGridView = new();

    public FilterTransportForm() => InitializeComponent();

    public FilterTransportForm(DataGridView dataGridView) : this() => _dataGridView = dataGridView;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        CheckBoxTransportID.Checked = _dataGridView.Columns[0].Visible;
        CheckBoxModel.Checked = _dataGridView.Columns[1].Visible;
        CheckBoxLicensePlate.Checked = _dataGridView.Columns[2].Visible;
        CheckBoxCapacity.Checked = _dataGridView.Columns[3].Visible;
        CheckBoxLastMaintenanceDate.Checked = _dataGridView.Columns[4].Visible;
        CheckBoxMileage.Checked = _dataGridView.Columns[5].Visible;
        CheckBoxTransportRouteID.Checked = _dataGridView.Columns[6].Visible;
        CheckBoxTransportRoute.Checked = _dataGridView.Columns[7].Visible;
        CheckBoxTransportDriverID.Checked = _dataGridView.Columns[8].Visible;
        CheckBoxTransportDriver.Checked = _dataGridView.Columns[9].Visible;
    }

    private void ButtonApply_Click(object sender, EventArgs e)
    {
        _dataGridView.Columns[0].Visible = CheckBoxTransportID.Checked;
        _dataGridView.Columns[1].Visible = CheckBoxModel.Checked;
        _dataGridView.Columns[2].Visible = CheckBoxLicensePlate.Checked;
        _dataGridView.Columns[3].Visible = CheckBoxCapacity.Checked;
        _dataGridView.Columns[4].Visible = CheckBoxLastMaintenanceDate.Checked;
        _dataGridView.Columns[5].Visible = CheckBoxMileage.Checked;
        _dataGridView.Columns[6].Visible = CheckBoxTransportRouteID.Checked;
        _dataGridView.Columns[7].Visible = CheckBoxTransportRoute.Checked;
        _dataGridView.Columns[8].Visible = CheckBoxTransportDriverID.Checked;
        _dataGridView.Columns[9].Visible = CheckBoxTransportDriver.Checked;

        string minCapacity = numericUpDown1.Text.ToLower();
        string maxMileage = numericUpDown2.Text.ToLower();

        CurrencyManager currencyManager = (CurrencyManager)BindingContext[_dataGridView.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in _dataGridView.Rows)
        {
            row.Visible = false;

            if (row.Cells["capacityDataGridViewTextBoxColumn"] != null
                && (int.Parse(row.Cells["capacityDataGridViewTextBoxColumn"].Value.ToString()) >= int.Parse(minCapacity))
                && row.Cells["mileageDataGridViewTextBoxColumn"] != null
                && (int.Parse(row.Cells["mileageDataGridViewTextBoxColumn"].Value.ToString()) <= int.Parse(maxMileage)))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
