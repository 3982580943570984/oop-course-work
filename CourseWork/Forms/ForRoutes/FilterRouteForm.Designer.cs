namespace CourseWork.Forms.ForRoutes;

partial class FilterRouteForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterRouteForm));
        ButtonExit = new Button();
        TableLayoutPanelAction = new TableLayoutPanel();
        ButtonApply = new Button();
        GroupBoxActions = new GroupBox();
        CheckBoxRouteID = new CheckBox();
        CheckBoxName = new CheckBox();
        CheckBoxStartLocation = new CheckBox();
        CheckBoxDistance = new CheckBox();
        TableLayoutPanelFilters = new TableLayoutPanel();
        CheckBoxEndLocation = new CheckBox();
        CheckBoxStartTime = new CheckBox();
        CheckBoxEndTime = new CheckBox();
        CheckBoxRouteTransports = new CheckBox();
        CheckBoxRouteDrivers = new CheckBox();
        GroupBoxFilters = new GroupBox();
        TableLayoutPanelMain = new TableLayoutPanel();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel3 = new TableLayoutPanel();
        label1 = new Label();
        numericUpDown1 = new NumericUpDown();
        TableLayoutPanelAction.SuspendLayout();
        GroupBoxActions.SuspendLayout();
        TableLayoutPanelFilters.SuspendLayout();
        GroupBoxFilters.SuspendLayout();
        TableLayoutPanelMain.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
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
        // CheckBoxRouteID
        // 
        CheckBoxRouteID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxRouteID.AutoSize = true;
        CheckBoxRouteID.Location = new Point(3, 4);
        CheckBoxRouteID.Name = "CheckBoxRouteID";
        CheckBoxRouteID.Size = new Size(214, 20);
        CheckBoxRouteID.TabIndex = 0;
        CheckBoxRouteID.Text = "ID";
        CheckBoxRouteID.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxRouteID.UseVisualStyleBackColor = true;
        // 
        // CheckBoxName
        // 
        CheckBoxName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxName.AutoSize = true;
        CheckBoxName.Location = new Point(3, 32);
        CheckBoxName.Name = "CheckBoxName";
        CheckBoxName.Size = new Size(214, 20);
        CheckBoxName.TabIndex = 1;
        CheckBoxName.Text = "Модель";
        CheckBoxName.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxName.UseVisualStyleBackColor = true;
        // 
        // CheckBoxStartLocation
        // 
        CheckBoxStartLocation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxStartLocation.AutoSize = true;
        CheckBoxStartLocation.Location = new Point(3, 60);
        CheckBoxStartLocation.Name = "CheckBoxStartLocation";
        CheckBoxStartLocation.Size = new Size(214, 20);
        CheckBoxStartLocation.TabIndex = 2;
        CheckBoxStartLocation.Text = "Стартовая точка";
        CheckBoxStartLocation.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxStartLocation.UseVisualStyleBackColor = true;
        // 
        // CheckBoxDistance
        // 
        CheckBoxDistance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxDistance.AutoSize = true;
        CheckBoxDistance.Location = new Point(3, 116);
        CheckBoxDistance.Name = "CheckBoxDistance";
        CheckBoxDistance.Size = new Size(214, 20);
        CheckBoxDistance.TabIndex = 4;
        CheckBoxDistance.Text = "Длина маршрута";
        CheckBoxDistance.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxDistance.UseVisualStyleBackColor = true;
        // 
        // TableLayoutPanelFilters
        // 
        TableLayoutPanelFilters.ColumnCount = 1;
        TableLayoutPanelFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelFilters.Controls.Add(CheckBoxName, 0, 1);
        TableLayoutPanelFilters.Controls.Add(CheckBoxStartLocation, 0, 2);
        TableLayoutPanelFilters.Controls.Add(CheckBoxEndLocation, 0, 3);
        TableLayoutPanelFilters.Controls.Add(CheckBoxDistance, 0, 4);
        TableLayoutPanelFilters.Controls.Add(CheckBoxStartTime, 0, 5);
        TableLayoutPanelFilters.Controls.Add(CheckBoxEndTime, 0, 6);
        TableLayoutPanelFilters.Controls.Add(CheckBoxRouteTransports, 0, 7);
        TableLayoutPanelFilters.Controls.Add(CheckBoxRouteDrivers, 0, 8);
        TableLayoutPanelFilters.Controls.Add(CheckBoxRouteID, 0, 0);
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
        // CheckBoxEndLocation
        // 
        CheckBoxEndLocation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxEndLocation.AutoSize = true;
        CheckBoxEndLocation.Location = new Point(3, 88);
        CheckBoxEndLocation.Name = "CheckBoxEndLocation";
        CheckBoxEndLocation.Size = new Size(214, 20);
        CheckBoxEndLocation.TabIndex = 3;
        CheckBoxEndLocation.Text = "Конечная точка";
        CheckBoxEndLocation.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxEndLocation.UseVisualStyleBackColor = true;
        // 
        // CheckBoxStartTime
        // 
        CheckBoxStartTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxStartTime.AutoSize = true;
        CheckBoxStartTime.Location = new Point(3, 144);
        CheckBoxStartTime.Name = "CheckBoxStartTime";
        CheckBoxStartTime.Size = new Size(214, 20);
        CheckBoxStartTime.TabIndex = 5;
        CheckBoxStartTime.Text = "Начало движения";
        CheckBoxStartTime.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxStartTime.UseVisualStyleBackColor = true;
        // 
        // CheckBoxEndTime
        // 
        CheckBoxEndTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxEndTime.AutoSize = true;
        CheckBoxEndTime.Location = new Point(3, 172);
        CheckBoxEndTime.Name = "CheckBoxEndTime";
        CheckBoxEndTime.Size = new Size(214, 20);
        CheckBoxEndTime.TabIndex = 6;
        CheckBoxEndTime.Text = "Конец движения";
        CheckBoxEndTime.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxEndTime.UseVisualStyleBackColor = true;
        // 
        // CheckBoxRouteTransports
        // 
        CheckBoxRouteTransports.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxRouteTransports.AutoSize = true;
        CheckBoxRouteTransports.Location = new Point(3, 200);
        CheckBoxRouteTransports.Name = "CheckBoxRouteTransports";
        CheckBoxRouteTransports.Size = new Size(214, 20);
        CheckBoxRouteTransports.TabIndex = 7;
        CheckBoxRouteTransports.Text = "Транспорт";
        CheckBoxRouteTransports.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxRouteTransports.UseVisualStyleBackColor = true;
        // 
        // CheckBoxRouteDrivers
        // 
        CheckBoxRouteDrivers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        CheckBoxRouteDrivers.AutoSize = true;
        CheckBoxRouteDrivers.Location = new Point(3, 231);
        CheckBoxRouteDrivers.Name = "CheckBoxRouteDrivers";
        CheckBoxRouteDrivers.Size = new Size(214, 20);
        CheckBoxRouteDrivers.TabIndex = 8;
        CheckBoxRouteDrivers.Text = "Водители";
        CheckBoxRouteDrivers.TextAlign = ContentAlignment.MiddleCenter;
        CheckBoxRouteDrivers.UseVisualStyleBackColor = true;
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
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
        tableLayoutPanel1.Controls.Add(TableLayoutPanelFilters, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 19);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(452, 264);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Controls.Add(label1, 0, 0);
        tableLayoutPanel3.Controls.Add(numericUpDown1, 0, 1);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(229, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new Size(220, 258);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Location = new Point(15, 56);
        label1.Name = "label1";
        label1.Size = new Size(189, 16);
        label1.TabIndex = 0;
        label1.Text = "Минимальная длина маршрута";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Anchor = AnchorStyles.None;
        numericUpDown1.BackColor = Color.FromArgb(198, 210, 237);
        numericUpDown1.Location = new Point(50, 182);
        numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(120, 23);
        numericUpDown1.TabIndex = 1;
        // 
        // FilterRouteForm
        // 
        AutoScaleDimensions = new SizeF(7F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(130, 112, 129);
        ClientSize = new Size(464, 365);
        Controls.Add(TableLayoutPanelMain);
        Font = new Font("JetBrainsMono Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "FilterRouteForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Настройка фильтра маршрутов";
        TableLayoutPanelAction.ResumeLayout(false);
        GroupBoxActions.ResumeLayout(false);
        TableLayoutPanelFilters.ResumeLayout(false);
        TableLayoutPanelFilters.PerformLayout();
        GroupBoxFilters.ResumeLayout(false);
        TableLayoutPanelMain.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button ButtonExit;
    private TableLayoutPanel TableLayoutPanelAction;
    private Button ButtonApply;
    private GroupBox GroupBoxActions;
    private CheckBox CheckBoxRouteID;
    private CheckBox CheckBoxName;
    private CheckBox CheckBoxStartLocation;
    private CheckBox CheckBoxDistance;
    private TableLayoutPanel TableLayoutPanelFilters;
    private CheckBox CheckBoxEndLocation;
    private CheckBox CheckBoxStartTime;
    private CheckBox CheckBoxEndTime;
    private CheckBox CheckBoxRouteTransports;
    private CheckBox CheckBoxRouteDrivers;
    private GroupBox GroupBoxFilters;
    private TableLayoutPanel TableLayoutPanelMain;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel3;
    private Label label1;
    private NumericUpDown numericUpDown1;
}