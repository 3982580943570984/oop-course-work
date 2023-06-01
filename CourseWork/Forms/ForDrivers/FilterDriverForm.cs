namespace CourseWork.Forms.ForDrivers;

public partial class FilterDriverForm : Form
{
    private readonly DataGridView _dataGridView = new();

    public FilterDriverForm() => InitializeComponent();

    public FilterDriverForm(DataGridView dataGridView) : this() => _dataGridView = dataGridView;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        CheckBoxDriverID.Checked = _dataGridView.Columns[0].Visible;
        CheckBoxFirstName.Checked = _dataGridView.Columns[1].Visible;
        CheckBoxLastName.Checked = _dataGridView.Columns[2].Visible;
        CheckBoxAge.Checked = _dataGridView.Columns[3].Visible;
        CheckBoxDrivingExperience.Checked = _dataGridView.Columns[4].Visible;
        CheckBoxDriverTransportID.Checked = _dataGridView.Columns[5].Visible;
        CheckBoxDriverTransport.Checked = _dataGridView.Columns[6].Visible;
        CheckBoxDriverRouteID.Checked = _dataGridView.Columns[7].Visible;
        CheckBoxDriverRoute.Checked = _dataGridView.Columns[8].Visible;
    }

    private void ButtonApply_Click(object sender, EventArgs e)
    {
        _dataGridView.Columns[0].Visible = CheckBoxDriverID.Checked;
        _dataGridView.Columns[1].Visible = CheckBoxFirstName.Checked;
        _dataGridView.Columns[2].Visible = CheckBoxLastName.Checked;
        _dataGridView.Columns[3].Visible = CheckBoxAge.Checked;
        _dataGridView.Columns[4].Visible = CheckBoxDrivingExperience.Checked;
        _dataGridView.Columns[5].Visible = CheckBoxDriverTransportID.Checked;
        _dataGridView.Columns[6].Visible = CheckBoxDriverTransport.Checked;
        _dataGridView.Columns[7].Visible = CheckBoxDriverRouteID.Checked;
        _dataGridView.Columns[8].Visible = CheckBoxDriverRoute.Checked;

        string maxAge = numericUpDown2.Text.ToLower();
        string minExperience = numericUpDown1.Text.ToLower();

        CurrencyManager currencyManager = (CurrencyManager)BindingContext[_dataGridView.DataSource];
        currencyManager.SuspendBinding();

        foreach (DataGridViewRow row in _dataGridView.Rows)
        {
            row.Visible = false;

            if (row.Cells["ageDataGridViewTextBoxColumn"] != null
                && (int.Parse(row.Cells["ageDataGridViewTextBoxColumn"].Value.ToString()) <= int.Parse(maxAge))
                && row.Cells["drivingExperienceDataGridViewTextBoxColumn"] != null
                && (int.Parse(row.Cells["drivingExperienceDataGridViewTextBoxColumn"].Value.ToString()) >= int.Parse(minExperience)))
                row.Visible = true;
        }

        currencyManager.ResumeBinding();
    }

    private void ButtonExit_Click(object sender, EventArgs e) => Close();
}
