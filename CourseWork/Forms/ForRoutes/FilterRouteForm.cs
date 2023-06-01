namespace CourseWork.Forms.ForRoutes;

public partial class FilterRouteForm : Form
{
    private readonly DataGridView _dataGridView = new();

    public FilterRouteForm() => InitializeComponent();

    public FilterRouteForm(DataGridView dataGridView) : this() => _dataGridView = dataGridView;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        CheckBoxRouteID.Checked = _dataGridView.Columns[0].Visible;
        CheckBoxName.Checked = _dataGridView.Columns[1].Visible;
        CheckBoxStartLocation.Checked = _dataGridView.Columns[2].Visible;
        CheckBoxEndLocation.Checked = _dataGridView.Columns[3].Visible;
        CheckBoxDistance.Checked = _dataGridView.Columns[4].Visible;
        CheckBoxStartTime.Checked = _dataGridView.Columns[5].Visible;
        CheckBoxEndTime.Checked = _dataGridView.Columns[6].Visible;
        /*        CheckBoxRouteTransports.Checked = _dataGridView.Columns[7].Visible;
                CheckBoxRouteDrivers.Checked = _dataGridView.Columns[8].Visible;*/
    }

    private void ButtonApply_Click(object sender, EventArgs e)
    {
        _dataGridView.Columns[0].Visible = CheckBoxRouteID.Checked;
        _dataGridView.Columns[1].Visible = CheckBoxName.Checked;
        _dataGridView.Columns[2].Visible = CheckBoxStartLocation.Checked;
        _dataGridView.Columns[3].Visible = CheckBoxEndLocation.Checked;
        _dataGridView.Columns[4].Visible = CheckBoxDistance.Checked;
        _dataGridView.Columns[5].Visible = CheckBoxStartTime.Checked;
        _dataGridView.Columns[6].Visible = CheckBoxEndTime.Checked;
        /*        _dataGridView.Columns[7].Visible = CheckBoxRouteTransports.Checked;
                _dataGridView.Columns[8].Visible = CheckBoxRouteDrivers.Checked;*/

        string minDistance = numericUpDown1.Text.ToLower();

        CurrencyManager currencyManager = (CurrencyManager)BindingContext[_dataGridView.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in _dataGridView.Rows)
        {
            row.Visible = false;

            if (row.Cells["distanceDataGridViewTextBoxColumn"] != null
                && (int.Parse(row.Cells["distanceDataGridViewTextBoxColumn"].Value.ToString()) >= int.Parse(minDistance)))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
