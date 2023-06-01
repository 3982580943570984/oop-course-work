namespace CourseWork.Forms.ForRoutes;

partial class UpdateRouteForm
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRouteForm));
        ButtonExit = new Button();
        ButtonUpdate = new Button();
        TableLayoutPanelActions = new TableLayoutPanel();
        GroupBoxActions = new GroupBox();
        TableLayoutPanelDriverInfo = new TableLayoutPanel();
        TableLayoutPanelMain = new TableLayoutPanel();
        GroupBoxParameters = new GroupBox();
        TableLayoutPanelDriverParameters = new TableLayoutPanel();
        LabelName = new Label();
        LabelDistance = new Label();
        LabelStartLocation = new Label();
        LabelEndLocation = new Label();
        LabelStartTime = new Label();
        LabelEndTime = new Label();
        LabelTransports = new Label();
        GroupBoxParametersValues = new GroupBox();
        TableLayoutPanelDriverParametersValue = new TableLayoutPanel();
        TextBoxName = new TextBox();
        NumericUpDownDistance = new NumericUpDown();
        TextBoxStartLocation = new TextBox();
        TextBoxEndLocation = new TextBox();
        DateTimePickerStartTime = new DateTimePicker();
        DateTimePickerEndTime = new DateTimePicker();
        ListBoxTransports = new ListBox();
        TransportBindingSource = new BindingSource(components);
        TableLayoutPanelActions.SuspendLayout();
        GroupBoxActions.SuspendLayout();
        TableLayoutPanelDriverInfo.SuspendLayout();
        TableLayoutPanelMain.SuspendLayout();
        GroupBoxParameters.SuspendLayout();
        TableLayoutPanelDriverParameters.SuspendLayout();
        GroupBoxParametersValues.SuspendLayout();
        TableLayoutPanelDriverParametersValue.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NumericUpDownDistance).BeginInit();
        ((System.ComponentModel.ISupportInitialize)TransportBindingSource).BeginInit();
        SuspendLayout();
        // 
        // ButtonExit
        // 
        ButtonExit.Anchor = AnchorStyles.None;
        ButtonExit.BackColor = Color.FromArgb(174, 163, 176);
        ButtonExit.FlatStyle = FlatStyle.Flat;
        ButtonExit.Location = new Point(614, 19);
        ButtonExit.Margin = new Padding(2);
        ButtonExit.Name = "ButtonExit";
        ButtonExit.Size = new Size(130, 25);
        ButtonExit.TabIndex = 0;
        ButtonExit.Text = "Отмена";
        ButtonExit.UseVisualStyleBackColor = false;
        ButtonExit.Click += ButtonExit_Click;
        // 
        // ButtonUpdate
        // 
        ButtonUpdate.Anchor = AnchorStyles.None;
        ButtonUpdate.BackColor = Color.FromArgb(174, 163, 176);
        ButtonUpdate.FlatStyle = FlatStyle.Flat;
        ButtonUpdate.Location = new Point(32, 19);
        ButtonUpdate.Margin = new Padding(2);
        ButtonUpdate.Name = "ButtonUpdate";
        ButtonUpdate.Size = new Size(130, 25);
        ButtonUpdate.TabIndex = 1;
        ButtonUpdate.Text = "Изменить";
        ButtonUpdate.UseVisualStyleBackColor = false;
        ButtonUpdate.Click += ButtonUpdate_Click;
        // 
        // TableLayoutPanelActions
        // 
        TableLayoutPanelActions.ColumnCount = 4;
        TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        TableLayoutPanelActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        TableLayoutPanelActions.Controls.Add(ButtonExit, 3, 0);
        TableLayoutPanelActions.Controls.Add(ButtonUpdate, 0, 0);
        TableLayoutPanelActions.Dock = DockStyle.Fill;
        TableLayoutPanelActions.Location = new Point(2, 18);
        TableLayoutPanelActions.Margin = new Padding(2);
        TableLayoutPanelActions.Name = "TableLayoutPanelActions";
        TableLayoutPanelActions.RowCount = 1;
        TableLayoutPanelActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TableLayoutPanelActions.Size = new Size(776, 64);
        TableLayoutPanelActions.TabIndex = 0;
        // 
        // GroupBoxActions
        // 
        GroupBoxActions.Controls.Add(TableLayoutPanelActions);
        GroupBoxActions.Dock = DockStyle.Fill;
        GroupBoxActions.Location = new Point(2, 479);
        GroupBoxActions.Margin = new Padding(2);
        GroupBoxActions.Name = "GroupBoxActions";
        GroupBoxActions.Padding = new Padding(2);
        GroupBoxActions.Size = new Size(780, 84);
        GroupBoxActions.TabIndex = 2;
        GroupBoxActions.TabStop = false;
        GroupBoxActions.Text = "Действия";
        // 
        // TableLayoutPanelDriverInfo
        // 
        TableLayoutPanelDriverInfo.ColumnCount = 1;
        TableLayoutPanelDriverInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelDriverInfo.Controls.Add(TableLayoutPanelMain, 0, 0);
        TableLayoutPanelDriverInfo.Controls.Add(GroupBoxActions, 0, 1);
        TableLayoutPanelDriverInfo.Dock = DockStyle.Fill;
        TableLayoutPanelDriverInfo.Location = new Point(0, 0);
        TableLayoutPanelDriverInfo.Margin = new Padding(2);
        TableLayoutPanelDriverInfo.Name = "TableLayoutPanelDriverInfo";
        TableLayoutPanelDriverInfo.RowCount = 2;
        TableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanelDriverInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
        TableLayoutPanelDriverInfo.Size = new Size(784, 565);
        TableLayoutPanelDriverInfo.TabIndex = 5;
        // 
        // TableLayoutPanelMain
        // 
        TableLayoutPanelMain.ColumnCount = 2;
        TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanelMain.Controls.Add(GroupBoxParameters, 0, 0);
        TableLayoutPanelMain.Controls.Add(GroupBoxParametersValues, 1, 0);
        TableLayoutPanelMain.Dock = DockStyle.Fill;
        TableLayoutPanelMain.Location = new Point(2, 2);
        TableLayoutPanelMain.Margin = new Padding(2);
        TableLayoutPanelMain.Name = "TableLayoutPanelMain";
        TableLayoutPanelMain.RowCount = 1;
        TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        TableLayoutPanelMain.Size = new Size(780, 473);
        TableLayoutPanelMain.TabIndex = 1;
        // 
        // GroupBoxParameters
        // 
        GroupBoxParameters.Controls.Add(TableLayoutPanelDriverParameters);
        GroupBoxParameters.Dock = DockStyle.Fill;
        GroupBoxParameters.Location = new Point(2, 2);
        GroupBoxParameters.Margin = new Padding(2);
        GroupBoxParameters.Name = "GroupBoxParameters";
        GroupBoxParameters.Padding = new Padding(2);
        GroupBoxParameters.Size = new Size(386, 469);
        GroupBoxParameters.TabIndex = 0;
        GroupBoxParameters.TabStop = false;
        GroupBoxParameters.Text = "Параметры";
        // 
        // TableLayoutPanelDriverParameters
        // 
        TableLayoutPanelDriverParameters.ColumnCount = 1;
        TableLayoutPanelDriverParameters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelDriverParameters.Controls.Add(LabelName, 0, 0);
        TableLayoutPanelDriverParameters.Controls.Add(LabelDistance, 0, 1);
        TableLayoutPanelDriverParameters.Controls.Add(LabelStartLocation, 0, 2);
        TableLayoutPanelDriverParameters.Controls.Add(LabelEndLocation, 0, 3);
        TableLayoutPanelDriverParameters.Controls.Add(LabelStartTime, 0, 4);
        TableLayoutPanelDriverParameters.Controls.Add(LabelEndTime, 0, 5);
        TableLayoutPanelDriverParameters.Controls.Add(LabelTransports, 0, 6);
        TableLayoutPanelDriverParameters.Dock = DockStyle.Fill;
        TableLayoutPanelDriverParameters.Location = new Point(2, 18);
        TableLayoutPanelDriverParameters.Margin = new Padding(2);
        TableLayoutPanelDriverParameters.Name = "TableLayoutPanelDriverParameters";
        TableLayoutPanelDriverParameters.RowCount = 7;
        TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParameters.Size = new Size(382, 449);
        TableLayoutPanelDriverParameters.TabIndex = 0;
        // 
        // LabelName
        // 
        LabelName.Anchor = AnchorStyles.None;
        LabelName.AutoSize = true;
        LabelName.Location = new Point(159, 24);
        LabelName.Margin = new Padding(2, 0, 2, 0);
        LabelName.Name = "LabelName";
        LabelName.Size = new Size(63, 16);
        LabelName.TabIndex = 0;
        LabelName.Text = "Название";
        // 
        // LabelDistance
        // 
        LabelDistance.Anchor = AnchorStyles.None;
        LabelDistance.AutoSize = true;
        LabelDistance.Location = new Point(152, 88);
        LabelDistance.Margin = new Padding(2, 0, 2, 0);
        LabelDistance.Name = "LabelDistance";
        LabelDistance.Size = new Size(77, 16);
        LabelDistance.TabIndex = 1;
        LabelDistance.Text = "Расстояние";
        // 
        // LabelStartLocation
        // 
        LabelStartLocation.Anchor = AnchorStyles.None;
        LabelStartLocation.AutoSize = true;
        LabelStartLocation.Location = new Point(121, 152);
        LabelStartLocation.Margin = new Padding(2, 0, 2, 0);
        LabelStartLocation.Name = "LabelStartLocation";
        LabelStartLocation.Size = new Size(140, 16);
        LabelStartLocation.TabIndex = 2;
        LabelStartLocation.Text = "Начальная остановка";
        // 
        // LabelEndLocation
        // 
        LabelEndLocation.Anchor = AnchorStyles.None;
        LabelEndLocation.AutoSize = true;
        LabelEndLocation.Location = new Point(124, 216);
        LabelEndLocation.Margin = new Padding(2, 0, 2, 0);
        LabelEndLocation.Name = "LabelEndLocation";
        LabelEndLocation.Size = new Size(133, 16);
        LabelEndLocation.TabIndex = 3;
        LabelEndLocation.Text = "Конечная остановка";
        // 
        // LabelStartTime
        // 
        LabelStartTime.Anchor = AnchorStyles.None;
        LabelStartTime.AutoSize = true;
        LabelStartTime.Location = new Point(114, 280);
        LabelStartTime.Margin = new Padding(2, 0, 2, 0);
        LabelStartTime.Name = "LabelStartTime";
        LabelStartTime.Size = new Size(154, 16);
        LabelStartTime.TabIndex = 4;
        LabelStartTime.Text = "Время начала маршрута";
        // 
        // LabelEndTime
        // 
        LabelEndTime.Anchor = AnchorStyles.None;
        LabelEndTime.AutoSize = true;
        LabelEndTime.Location = new Point(103, 344);
        LabelEndTime.Margin = new Padding(2, 0, 2, 0);
        LabelEndTime.Name = "LabelEndTime";
        LabelEndTime.Size = new Size(175, 16);
        LabelEndTime.TabIndex = 5;
        LabelEndTime.Text = "Время окончания маршрута";
        // 
        // LabelTransports
        // 
        LabelTransports.Anchor = AnchorStyles.None;
        LabelTransports.AutoSize = true;
        LabelTransports.Location = new Point(107, 408);
        LabelTransports.Name = "LabelTransports";
        LabelTransports.Size = new Size(168, 16);
        LabelTransports.TabIndex = 6;
        LabelTransports.Text = "Обслуживающий транспорт";
        // 
        // GroupBoxParametersValues
        // 
        GroupBoxParametersValues.Controls.Add(TableLayoutPanelDriverParametersValue);
        GroupBoxParametersValues.Dock = DockStyle.Fill;
        GroupBoxParametersValues.Location = new Point(392, 2);
        GroupBoxParametersValues.Margin = new Padding(2);
        GroupBoxParametersValues.Name = "GroupBoxParametersValues";
        GroupBoxParametersValues.Padding = new Padding(2);
        GroupBoxParametersValues.Size = new Size(386, 469);
        GroupBoxParametersValues.TabIndex = 1;
        GroupBoxParametersValues.TabStop = false;
        GroupBoxParametersValues.Text = "Значения";
        // 
        // TableLayoutPanelDriverParametersValue
        // 
        TableLayoutPanelDriverParametersValue.ColumnCount = 1;
        TableLayoutPanelDriverParametersValue.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TableLayoutPanelDriverParametersValue.Controls.Add(TextBoxName, 0, 0);
        TableLayoutPanelDriverParametersValue.Controls.Add(NumericUpDownDistance, 0, 1);
        TableLayoutPanelDriverParametersValue.Controls.Add(TextBoxStartLocation, 0, 2);
        TableLayoutPanelDriverParametersValue.Controls.Add(TextBoxEndLocation, 0, 3);
        TableLayoutPanelDriverParametersValue.Controls.Add(DateTimePickerStartTime, 0, 4);
        TableLayoutPanelDriverParametersValue.Controls.Add(DateTimePickerEndTime, 0, 5);
        TableLayoutPanelDriverParametersValue.Controls.Add(ListBoxTransports, 0, 6);
        TableLayoutPanelDriverParametersValue.Dock = DockStyle.Fill;
        TableLayoutPanelDriverParametersValue.Location = new Point(2, 18);
        TableLayoutPanelDriverParametersValue.Margin = new Padding(2);
        TableLayoutPanelDriverParametersValue.Name = "TableLayoutPanelDriverParametersValue";
        TableLayoutPanelDriverParametersValue.RowCount = 7;
        TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        TableLayoutPanelDriverParametersValue.Size = new Size(382, 449);
        TableLayoutPanelDriverParametersValue.TabIndex = 0;
        // 
        // TextBoxName
        // 
        TextBoxName.Anchor = AnchorStyles.None;
        TextBoxName.BackColor = Color.FromArgb(198, 210, 237);
        TextBoxName.Location = new Point(41, 20);
        TextBoxName.Name = "TextBoxName";
        TextBoxName.Size = new Size(300, 23);
        TextBoxName.TabIndex = 0;
        // 
        // NumericUpDownDistance
        // 
        NumericUpDownDistance.Anchor = AnchorStyles.None;
        NumericUpDownDistance.BackColor = Color.FromArgb(198, 210, 237);
        NumericUpDownDistance.Location = new Point(41, 84);
        NumericUpDownDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        NumericUpDownDistance.Name = "NumericUpDownDistance";
        NumericUpDownDistance.Size = new Size(300, 23);
        NumericUpDownDistance.TabIndex = 1;
        // 
        // TextBoxStartLocation
        // 
        TextBoxStartLocation.Anchor = AnchorStyles.None;
        TextBoxStartLocation.BackColor = Color.FromArgb(198, 210, 237);
        TextBoxStartLocation.Location = new Point(41, 148);
        TextBoxStartLocation.Name = "TextBoxStartLocation";
        TextBoxStartLocation.Size = new Size(300, 23);
        TextBoxStartLocation.TabIndex = 2;
        // 
        // TextBoxEndLocation
        // 
        TextBoxEndLocation.Anchor = AnchorStyles.None;
        TextBoxEndLocation.BackColor = Color.FromArgb(198, 210, 237);
        TextBoxEndLocation.Location = new Point(41, 212);
        TextBoxEndLocation.Name = "TextBoxEndLocation";
        TextBoxEndLocation.Size = new Size(300, 23);
        TextBoxEndLocation.TabIndex = 3;
        // 
        // DateTimePickerStartTime
        // 
        DateTimePickerStartTime.Anchor = AnchorStyles.None;
        DateTimePickerStartTime.Format = DateTimePickerFormat.Time;
        DateTimePickerStartTime.Location = new Point(41, 276);
        DateTimePickerStartTime.Name = "DateTimePickerStartTime";
        DateTimePickerStartTime.Size = new Size(300, 23);
        DateTimePickerStartTime.TabIndex = 4;
        DateTimePickerStartTime.Value = new DateTime(2023, 5, 29, 16, 30, 47, 0);
        // 
        // DateTimePickerEndTime
        // 
        DateTimePickerEndTime.Anchor = AnchorStyles.None;
        DateTimePickerEndTime.Format = DateTimePickerFormat.Time;
        DateTimePickerEndTime.Location = new Point(41, 340);
        DateTimePickerEndTime.Name = "DateTimePickerEndTime";
        DateTimePickerEndTime.Size = new Size(300, 23);
        DateTimePickerEndTime.TabIndex = 5;
        DateTimePickerEndTime.Value = new DateTime(2023, 5, 29, 16, 30, 54, 0);
        // 
        // ListBoxTransports
        // 
        ListBoxTransports.BackColor = Color.FromArgb(198, 210, 237);
        ListBoxTransports.DataSource = TransportBindingSource;
        ListBoxTransports.Dock = DockStyle.Fill;
        ListBoxTransports.FormattingEnabled = true;
        ListBoxTransports.ItemHeight = 16;
        ListBoxTransports.Location = new Point(3, 387);
        ListBoxTransports.Name = "ListBoxTransports";
        ListBoxTransports.SelectionMode = SelectionMode.MultiSimple;
        ListBoxTransports.Size = new Size(376, 59);
        ListBoxTransports.TabIndex = 6;
        // 
        // TransportBindingSource
        // 
        TransportBindingSource.DataSource = typeof(Entities.Transport);
        // 
        // UpdateRouteForm
        // 
        AutoScaleDimensions = new SizeF(7F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(130, 112, 129);
        ClientSize = new Size(784, 565);
        Controls.Add(TableLayoutPanelDriverInfo);
        Font = new Font("JetBrainsMono Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(800, 600);
        Name = "UpdateRouteForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Изменить параметры маршрута";
        TableLayoutPanelActions.ResumeLayout(false);
        GroupBoxActions.ResumeLayout(false);
        TableLayoutPanelDriverInfo.ResumeLayout(false);
        TableLayoutPanelMain.ResumeLayout(false);
        GroupBoxParameters.ResumeLayout(false);
        TableLayoutPanelDriverParameters.ResumeLayout(false);
        TableLayoutPanelDriverParameters.PerformLayout();
        GroupBoxParametersValues.ResumeLayout(false);
        TableLayoutPanelDriverParametersValue.ResumeLayout(false);
        TableLayoutPanelDriverParametersValue.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NumericUpDownDistance).EndInit();
        ((System.ComponentModel.ISupportInitialize)TransportBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button ButtonExit;
    private Button ButtonUpdate;
    private TableLayoutPanel TableLayoutPanelActions;
    private GroupBox GroupBoxActions;
    private TableLayoutPanel TableLayoutPanelDriverInfo;
    private TableLayoutPanel TableLayoutPanelMain;
    private GroupBox GroupBoxParameters;
    private TableLayoutPanel TableLayoutPanelDriverParameters;
    private Label LabelName;
    private Label LabelDistance;
    private Label LabelStartLocation;
    private Label LabelEndLocation;
    private Label LabelStartTime;
    private Label LabelEndTime;
    private Label LabelTransports;
    private GroupBox GroupBoxParametersValues;
    private TableLayoutPanel TableLayoutPanelDriverParametersValue;
    private TextBox TextBoxName;
    private NumericUpDown NumericUpDownDistance;
    private TextBox TextBoxStartLocation;
    private TextBox TextBoxEndLocation;
    private DateTimePicker DateTimePickerStartTime;
    private DateTimePicker DateTimePickerEndTime;
    private ListBox ListBoxTransports;
    private BindingSource TransportBindingSource;
}