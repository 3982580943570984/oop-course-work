namespace CourseWork.Forms.ForTransports
{
    partial class FilterTransportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterTransportForm));
            TableLayoutPanelMain = new TableLayoutPanel();
            GroupBoxFilters = new GroupBox();
            TableLayoutPanelFilters = new TableLayoutPanel();
            CheckBoxModel = new CheckBox();
            CheckBoxLicensePlate = new CheckBox();
            CheckBoxCapacity = new CheckBox();
            CheckBoxLastMaintenanceDate = new CheckBox();
            CheckBoxMileage = new CheckBox();
            CheckBoxTransportRouteID = new CheckBox();
            CheckBoxTransportRoute = new CheckBox();
            CheckBoxTransportDriverID = new CheckBox();
            CheckBoxTransportDriver = new CheckBox();
            CheckBoxTransportID = new CheckBox();
            GroupBoxActions = new GroupBox();
            TableLayoutPanelAction = new TableLayoutPanel();
            ButtonApply = new Button();
            ButtonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            TableLayoutPanelMain.SuspendLayout();
            GroupBoxFilters.SuspendLayout();
            TableLayoutPanelFilters.SuspendLayout();
            GroupBoxActions.SuspendLayout();
            TableLayoutPanelAction.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
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
            TableLayoutPanelMain.TabIndex = 0;
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
            // TableLayoutPanelFilters
            // 
            TableLayoutPanelFilters.Anchor = AnchorStyles.None;
            TableLayoutPanelFilters.ColumnCount = 1;
            TableLayoutPanelFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelFilters.Controls.Add(CheckBoxModel, 0, 1);
            TableLayoutPanelFilters.Controls.Add(CheckBoxLicensePlate, 0, 2);
            TableLayoutPanelFilters.Controls.Add(CheckBoxCapacity, 0, 3);
            TableLayoutPanelFilters.Controls.Add(CheckBoxLastMaintenanceDate, 0, 4);
            TableLayoutPanelFilters.Controls.Add(CheckBoxMileage, 0, 5);
            TableLayoutPanelFilters.Controls.Add(CheckBoxTransportRouteID, 0, 6);
            TableLayoutPanelFilters.Controls.Add(CheckBoxTransportRoute, 0, 7);
            TableLayoutPanelFilters.Controls.Add(CheckBoxTransportDriverID, 0, 8);
            TableLayoutPanelFilters.Controls.Add(CheckBoxTransportDriver, 0, 9);
            TableLayoutPanelFilters.Controls.Add(CheckBoxTransportID, 0, 0);
            TableLayoutPanelFilters.Location = new Point(3, 3);
            TableLayoutPanelFilters.Name = "TableLayoutPanelFilters";
            TableLayoutPanelFilters.RowCount = 10;
            TableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
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
            // CheckBoxModel
            // 
            CheckBoxModel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxModel.AutoSize = true;
            CheckBoxModel.Location = new Point(3, 28);
            CheckBoxModel.Name = "CheckBoxModel";
            CheckBoxModel.Size = new Size(214, 19);
            CheckBoxModel.TabIndex = 1;
            CheckBoxModel.Text = "Модель";
            CheckBoxModel.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxModel.UseVisualStyleBackColor = true;
            // 
            // CheckBoxLicensePlate
            // 
            CheckBoxLicensePlate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxLicensePlate.AutoSize = true;
            CheckBoxLicensePlate.Location = new Point(3, 53);
            CheckBoxLicensePlate.Name = "CheckBoxLicensePlate";
            CheckBoxLicensePlate.Size = new Size(214, 19);
            CheckBoxLicensePlate.TabIndex = 2;
            CheckBoxLicensePlate.Text = "Номерной знак";
            CheckBoxLicensePlate.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxLicensePlate.UseVisualStyleBackColor = true;
            // 
            // CheckBoxCapacity
            // 
            CheckBoxCapacity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxCapacity.AutoSize = true;
            CheckBoxCapacity.Location = new Point(3, 78);
            CheckBoxCapacity.Name = "CheckBoxCapacity";
            CheckBoxCapacity.Size = new Size(214, 19);
            CheckBoxCapacity.TabIndex = 3;
            CheckBoxCapacity.Text = "Количество мест";
            CheckBoxCapacity.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxCapacity.UseVisualStyleBackColor = true;
            // 
            // CheckBoxLastMaintenanceDate
            // 
            CheckBoxLastMaintenanceDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxLastMaintenanceDate.AutoSize = true;
            CheckBoxLastMaintenanceDate.Location = new Point(3, 103);
            CheckBoxLastMaintenanceDate.Name = "CheckBoxLastMaintenanceDate";
            CheckBoxLastMaintenanceDate.Size = new Size(214, 19);
            CheckBoxLastMaintenanceDate.TabIndex = 4;
            CheckBoxLastMaintenanceDate.Text = "Дата тех. обслуживания";
            CheckBoxLastMaintenanceDate.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxLastMaintenanceDate.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMileage
            // 
            CheckBoxMileage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxMileage.AutoSize = true;
            CheckBoxMileage.Location = new Point(3, 128);
            CheckBoxMileage.Name = "CheckBoxMileage";
            CheckBoxMileage.Size = new Size(214, 19);
            CheckBoxMileage.TabIndex = 5;
            CheckBoxMileage.Text = "Пробег";
            CheckBoxMileage.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxMileage.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTransportRouteID
            // 
            CheckBoxTransportRouteID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxTransportRouteID.AutoSize = true;
            CheckBoxTransportRouteID.Location = new Point(3, 153);
            CheckBoxTransportRouteID.Name = "CheckBoxTransportRouteID";
            CheckBoxTransportRouteID.Size = new Size(214, 19);
            CheckBoxTransportRouteID.TabIndex = 6;
            CheckBoxTransportRouteID.Text = "ID Маршрута";
            CheckBoxTransportRouteID.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxTransportRouteID.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTransportRoute
            // 
            CheckBoxTransportRoute.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxTransportRoute.AutoSize = true;
            CheckBoxTransportRoute.Location = new Point(3, 178);
            CheckBoxTransportRoute.Name = "CheckBoxTransportRoute";
            CheckBoxTransportRoute.Size = new Size(214, 19);
            CheckBoxTransportRoute.TabIndex = 7;
            CheckBoxTransportRoute.Text = "Маршрут";
            CheckBoxTransportRoute.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxTransportRoute.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTransportDriverID
            // 
            CheckBoxTransportDriverID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxTransportDriverID.AutoSize = true;
            CheckBoxTransportDriverID.Location = new Point(3, 203);
            CheckBoxTransportDriverID.Name = "CheckBoxTransportDriverID";
            CheckBoxTransportDriverID.Size = new Size(214, 19);
            CheckBoxTransportDriverID.TabIndex = 8;
            CheckBoxTransportDriverID.Text = "ID Водителя";
            CheckBoxTransportDriverID.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxTransportDriverID.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTransportDriver
            // 
            CheckBoxTransportDriver.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxTransportDriver.AutoSize = true;
            CheckBoxTransportDriver.Location = new Point(3, 231);
            CheckBoxTransportDriver.Name = "CheckBoxTransportDriver";
            CheckBoxTransportDriver.Size = new Size(214, 20);
            CheckBoxTransportDriver.TabIndex = 9;
            CheckBoxTransportDriver.Text = "Водитель";
            CheckBoxTransportDriver.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxTransportDriver.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTransportID
            // 
            CheckBoxTransportID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CheckBoxTransportID.AutoSize = true;
            CheckBoxTransportID.Location = new Point(3, 3);
            CheckBoxTransportID.Name = "CheckBoxTransportID";
            CheckBoxTransportID.Size = new Size(214, 19);
            CheckBoxTransportID.TabIndex = 0;
            CheckBoxTransportID.Text = "ID";
            CheckBoxTransportID.TextAlign = ContentAlignment.MiddleCenter;
            CheckBoxTransportID.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(214, 123);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(numericUpDown2, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 132);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(214, 123);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(9, 22);
            label1.Name = "label1";
            label1.Size = new Size(196, 16);
            label1.TabIndex = 0;
            label1.Text = "Минимальное количество мест";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(37, 22);
            label2.Name = "label2";
            label2.Size = new Size(140, 16);
            label2.TabIndex = 0;
            label2.Text = "Максимальный пробег";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.BackColor = Color.FromArgb(198, 210, 237);
            numericUpDown1.Location = new Point(47, 80);
            numericUpDown1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.None;
            numericUpDown2.BackColor = Color.FromArgb(198, 210, 237);
            numericUpDown2.Location = new Point(47, 80);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // FilterTransportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 112, 129);
            ClientSize = new Size(464, 365);
            Controls.Add(TableLayoutPanelMain);
            Font = new Font("JetBrainsMono Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(480, 400);
            Name = "FilterTransportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройка фильтра транспорта";
            TableLayoutPanelMain.ResumeLayout(false);
            GroupBoxFilters.ResumeLayout(false);
            TableLayoutPanelFilters.ResumeLayout(false);
            TableLayoutPanelFilters.PerformLayout();
            GroupBoxActions.ResumeLayout(false);
            TableLayoutPanelAction.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelMain;
        private GroupBox GroupBoxFilters;
        private GroupBox GroupBoxActions;
        private TableLayoutPanel TableLayoutPanelFilters;
        private TableLayoutPanel TableLayoutPanelAction;
        private Button ButtonApply;
        private Button ButtonExit;
        private CheckBox CheckBoxTransportID;
        private CheckBox CheckBoxModel;
        private CheckBox CheckBoxLicensePlate;
        private CheckBox CheckBoxCapacity;
        private CheckBox CheckBoxLastMaintenanceDate;
        private CheckBox CheckBoxMileage;
        private CheckBox CheckBoxTransportRouteID;
        private CheckBox CheckBoxTransportRoute;
        private CheckBox CheckBoxTransportDriverID;
        private CheckBox CheckBoxTransportDriver;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}