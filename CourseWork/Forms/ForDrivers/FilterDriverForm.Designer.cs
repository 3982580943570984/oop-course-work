namespace CourseWork.Forms.ForDrivers;

partial class FilterDriverForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterDriverForm));
        CheckBoxDriverID = new CheckBox();
        ButtonApply = new Button();
        ButtonExit = new Button();
        TableLayoutPanelFilters = new TableLayoutPanel();
        CheckBoxFirstName = new CheckBox();
        CheckBoxLastName = new CheckBox();
        CheckBoxAge = new CheckBox();
        CheckBoxDrivingExperience = new CheckBox();
        CheckBoxDriverTransportID = new CheckBox();
        CheckBoxDriverTransport = new CheckBox();
        CheckBoxDriverRouteID = new CheckBox();
        CheckBoxDriverRoute = new CheckBox();
        GroupBoxFilters = new GroupBox();
        GroupBoxActions = new GroupBox();
        TableLayoutPanelAction = new TableLayoutPanel();
        TableLayoutPanelMain = new TableLayoutPanel();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        numericUpDown1 = new NumericUpDown();
        numericUpDown2 = new NumericUpDown();
        tableLayoutPanel3 = new TableLayoutPanel();
        tableLayoutPanel4 = new TableLayoutPanel();
        label1 = new Label();
        label2 = new Label();
        TableLayoutPanelFilters.SuspendLayout();
        GroupBoxFilters.SuspendLayout();
        GroupBoxActions.SuspendLayout();
        TableLayoutPanelAction.SuspendLayout();
        TableLayoutPanelMain.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        SuspendLayout();
        // 
        // CheckBoxDriverID
        // 
        CheckBoxDriverID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxDriverID.AutoSize = true;
        CheckBoxDriverID.Location = new Point(3, 4);
        CheckBoxDriverID.Name = "CheckBoxDriverID";
        CheckBoxDriverID.Size = new Size(214, 20);
        CheckBoxDriverID.TabIndex = 0;
        CheckBoxDriverID.Text = "ID";
        CheckBoxDriverID.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxDriverID.UseVisualStyleBackColor = true;
        // 
        // ButtonApply
        // 
        ButtonApply.Anchor = AnchorStyles.None;
        ButtonApply.BackColor = Color.FromArgb(174, 163, 176);
        ButtonApply.FlatStyle = FlatStyle.Flat;
        ButtonApply.Location = new Point(63, 10);
        ButtonApply.Name = "ButtonApply";
        ButtonApply.Size = new Size(100, 25);
        ButtonApply.TabIndex = 0;
        ButtonApply.Text = "Применить";
        ButtonApply.UseVisualStyleBackColor = false;
        ButtonApply.Click += ButtonApply_Click;
        // 
        // ButtonExit
        // 
        ButtonExit.Anchor = AnchorStyles.None;
        ButtonExit.BackColor = Color.FromArgb(174, 163, 176);
        ButtonExit.FlatStyle = FlatStyle.Flat;
        ButtonExit.Location = new Point(289, 10);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(100, 25);
        ButtonExit.TabIndex = 1;
        ButtonExit.Text = "Отмена";
        ButtonExit.UseVisualStyleBackColor = false;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // TableLayoutPanelFilters
        // 
        TableLayoutPanelFilters.Anchor = AnchorStyles.None;
        TableLayoutPanelFilters.ColumnCount = 1;
        TableLayoutPanelFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelFilters.Controls.Add(CheckBoxDriverID, 0, 0);
        TableLayoutPanelFilters.Controls.Add(CheckBoxFirstName, 0, 1);
        TableLayoutPanelFilters.Controls.Add(CheckBoxLastName, 0, 2);
        TableLayoutPanelFilters.Controls.Add(CheckBoxAge, 0, 3);
        TableLayoutPanelFilters.Controls.Add(CheckBoxDrivingExperience, 0, 4);
        TableLayoutPanelFilters.Controls.Add(CheckBoxDriverTransportID, 0, 5);
        TableLayoutPanelFilters.Controls.Add(CheckBoxDriverTransport, 0, 6);
        TableLayoutPanelFilters.Controls.Add(CheckBoxDriverRouteID, 0, 7);
        TableLayoutPanelFilters.Controls.Add(CheckBoxDriverRoute, 0, 8);
        TableLayoutPanelFilters.Location = new Point(3, 3);
        TableLayoutPanelFilters.Name = "TableLayoutPanelFilters";
        TableLayoutPanelFilters.RowCount = 9;
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        TableLayoutPanelFilters.Size = new Size(220, 258);
        TableLayoutPanelFilters.TabIndex = 0;
        // 
        // CheckBoxFirstName
        // 
        CheckBoxFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxFirstName.AutoSize = true;
        CheckBoxFirstName.Location = new Point(3, 32);
        CheckBoxFirstName.Name = "CheckBoxFirstName";
        CheckBoxFirstName.Size = new Size(214, 20);
        CheckBoxFirstName.TabIndex = 1;
        CheckBoxFirstName.Text = "Имя";
        CheckBoxFirstName.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxFirstName.UseVisualStyleBackColor = true;
        // 
        // CheckBoxLastName
        // 
        CheckBoxLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxLastName.AutoSize = true;
        CheckBoxLastName.Location = new Point(3, 60);
        CheckBoxLastName.Name = "CheckBoxLastName";
        CheckBoxLastName.Size = new Size(214, 20);
        CheckBoxLastName.TabIndex = 2;
        CheckBoxLastName.Text = "Фамилия";
        CheckBoxLastName.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxLastName.UseVisualStyleBackColor = true;
        // 
        // CheckBoxAge
        // 
        CheckBoxAge.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxAge.AutoSize = true;
        CheckBoxAge.Location = new Point(3, 88);
        CheckBoxAge.Name = "CheckBoxAge";
        CheckBoxAge.Size = new Size(214, 20);
        CheckBoxAge.TabIndex = 3;
        CheckBoxAge.Text = "Возраст";
        CheckBoxAge.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxAge.UseVisualStyleBackColor = true;
        // 
        // CheckBoxDrivingExperience
        // 
        CheckBoxDrivingExperience.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxDrivingExperience.AutoSize = true;
        CheckBoxDrivingExperience.Location = new Point(3, 116);
        CheckBoxDrivingExperience.Name = "CheckBoxDrivingExperience";
        CheckBoxDrivingExperience.Size = new Size(214, 20);
        CheckBoxDrivingExperience.TabIndex = 4;
        CheckBoxDrivingExperience.Text = "Опыт вождения";
        CheckBoxDrivingExperience.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxDrivingExperience.UseVisualStyleBackColor = true;
        // 
        // CheckBoxDriverTransportID
        // 
        CheckBoxDriverTransportID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxDriverTransportID.AutoSize = true;
        CheckBoxDriverTransportID.Location = new Point(3, 144);
        CheckBoxDriverTransportID.Name = "CheckBoxDriverTransportID";
        CheckBoxDriverTransportID.Size = new Size(214, 20);
        CheckBoxDriverTransportID.TabIndex = 5;
        CheckBoxDriverTransportID.Text = "ID Транспорта";
        CheckBoxDriverTransportID.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxDriverTransportID.UseVisualStyleBackColor = true;
        // 
        // CheckBoxDriverTransport
        // 
        CheckBoxDriverTransport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxDriverTransport.AutoSize = true;
        CheckBoxDriverTransport.Location = new Point(3, 172);
        CheckBoxDriverTransport.Name = "CheckBoxDriverTransport";
        CheckBoxDriverTransport.Size = new Size(214, 20);
        CheckBoxDriverTransport.TabIndex = 6;
        CheckBoxDriverTransport.Text = "Транспорт";
        CheckBoxDriverTransport.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxDriverTransport.UseVisualStyleBackColor = true;
        // 
        // CheckBoxDriverRouteID
        // 
        CheckBoxDriverRouteID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxDriverRouteID.AutoSize = true;
        CheckBoxDriverRouteID.Location = new Point(3, 200);
        CheckBoxDriverRouteID.Name = "CheckBoxDriverRouteID";
        CheckBoxDriverRouteID.Size = new Size(214, 20);
        CheckBoxDriverRouteID.TabIndex = 7;
        CheckBoxDriverRouteID.Text = "ID Маршрута";
        CheckBoxDriverRouteID.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxDriverRouteID.UseVisualStyleBackColor = true;
        // 
        // CheckBoxDriverRoute
        // 
        CheckBoxDriverRoute.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxDriverRoute.AutoSize = true;
        CheckBoxDriverRoute.Location = new Point(3, 231);
        CheckBoxDriverRoute.Name = "CheckBoxDriverRoute";
        CheckBoxDriverRoute.Size = new Size(214, 20);
        CheckBoxDriverRoute.TabIndex = 8;
        CheckBoxDriverRoute.Text = "Маршрут";
        CheckBoxDriverRoute.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxDriverRoute.UseVisualStyleBackColor = true;
        // 
        // GroupBoxFilters
        // 
        GroupBoxFilters.Controls.Add(tableLayoutPanel1);
        GroupBoxFilters.Dock = DockStyle.Fill;
        GroupBoxFilters.Location = new Point(3, 3);
        GroupBoxFilters.Name = "GroupBoxFilters";
        GroupBoxFilters.Size = new Size(458, 286);
        GroupBoxFilters.TabIndex = 0;
        GroupBoxFilters.TabStop = false;
        GroupBoxFilters.Text = "Фильтры";
        // 
        // GroupBoxActions
        // 
        GroupBoxActions.Controls.Add(TableLayoutPanelAction);
        GroupBoxActions.Dock = DockStyle.Fill;
        GroupBoxActions.Location = new Point(3, 295);
        GroupBoxActions.Name = "GroupBoxActions";
        GroupBoxActions.Size = new Size(458, 67);
        GroupBoxActions.TabIndex = 1;
        GroupBoxActions.TabStop = false;
        GroupBoxActions.Text = "Действия";
        // 
        // TableLayoutPanelAction
        // 
        TableLayoutPanelAction.ColumnCount = 2;
        TableLayoutPanelAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelAction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelAction.Controls.Add(ButtonApply, 0, 0);
        TableLayoutPanelAction.Controls.Add(ButtonExit, 1, 0);
        TableLayoutPanelAction.Dock = DockStyle.Fill;
        TableLayoutPanelAction.Location = new Point(3, 19);
        TableLayoutPanelAction.Name = "TableLayoutPanelAction";
        TableLayoutPanelAction.RowCount = 1;
        TableLayoutPanelAction.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TableLayoutPanelAction.Size = new Size(452, 45);
        TableLayoutPanelAction.TabIndex = 0;
        // 
        // TableLayoutPanelMain
        // 
        TableLayoutPanelMain.ColumnCount = 1;
        TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelMain.Controls.Add(GroupBoxFilters, 0, 0);
        TableLayoutPanelMain.Controls.Add(GroupBoxActions, 0, 1);
        TableLayoutPanelMain.Dock = DockStyle.Fill;
        TableLayoutPanelMain.Location = new Point(0, 0);
        TableLayoutPanelMain.Name = "TableLayoutPanelMain";
        TableLayoutPanelMain.RowCount = 2;
        TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        TableLayoutPanelMain.Size = new Size(464, 365);
        TableLayoutPanelMain.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(TableLayoutPanelFilters, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 19);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(452, 264);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(229, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new Size(220, 258);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Anchor = AnchorStyles.None;
        numericUpDown1.BackColor = Color.FromArgb(198, 210, 237);
        numericUpDown1.Location = new Point(47, 80);
        numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(120, 23);
        numericUpDown1.TabIndex = 0;
        numericUpDown1.Tag = "";
        // 
        // numericUpDown2
        // 
        numericUpDown2.Anchor = AnchorStyles.None;
        numericUpDown2.BackColor = Color.FromArgb(198, 210, 237);
        numericUpDown2.Location = new Point(47, 80);
        numericUpDown2.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        numericUpDown2.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(120, 23);
        numericUpDown2.TabIndex = 1;
        numericUpDown2.Value = new decimal(new int[] { 18, 0, 0, 0 });
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(numericUpDown2, 0, 1);
        tableLayoutPanel3.Controls.Add(label2, 0, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new Size(214, 123);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(numericUpDown1, 0, 1);
        tableLayoutPanel4.Controls.Add(label1, 0, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(3, 132);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new Size(214, 123);
        tableLayoutPanel4.TabIndex = 3;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Location = new Point(47, 22);
        label1.Name = "label1";
        label1.Size = new Size(119, 16);
        label1.TabIndex = 1;
        label1.Text = "Минимальный опыт";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.AutoSize = true;
        label2.Location = new Point(33, 22);
        label2.Name = "label2";
        label2.Size = new Size(147, 16);
        label2.TabIndex = 2;
        label2.Text = "Максимальный возраст";
        // 
        // FilterDriverForm
        // 
        AutoScaleDimensions = new SizeF(7F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(130, 112, 129);
        ClientSize = new Size(464, 365);
        Controls.Add(TableLayoutPanelMain);
        Font = new Font("JetBrainsMono Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(480, 400);
        Name = "FilterDriverForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Настройка фильтра водителей";
        TableLayoutPanelFilters.ResumeLayout(false);
        TableLayoutPanelFilters.PerformLayout();
        GroupBoxFilters.ResumeLayout(false);
        GroupBoxActions.ResumeLayout(false);
        TableLayoutPanelAction.ResumeLayout(false);
        TableLayoutPanelMain.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private CheckBox CheckBoxDriverID;
    private Button ButtonApply;
    private Button ButtonExit;
    private TableLayoutPanel TableLayoutPanelFilters;
    private CheckBox CheckBoxFirstName;
    private CheckBox CheckBoxLastName;
    private CheckBox CheckBoxAge;
    private CheckBox CheckBoxDrivingExperience;
    private CheckBox CheckBoxDriverTransportID;
    private CheckBox CheckBoxDriverTransport;
    private CheckBox CheckBoxDriverRouteID;
    private CheckBox CheckBoxDriverRoute;
    private GroupBox GroupBoxFilters;
    private GroupBox GroupBoxActions;
    private TableLayoutPanel TableLayoutPanelAction;
    private TableLayoutPanel TableLayoutPanelMain;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel3;
    private NumericUpDown numericUpDown2;
    private Label label2;
    private TableLayoutPanel tableLayoutPanel4;
    private NumericUpDown numericUpDown1;
    private Label label1;
}