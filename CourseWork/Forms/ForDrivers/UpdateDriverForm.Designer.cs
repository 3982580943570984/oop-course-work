namespace CourseWork.Forms.ForTransports
{
    partial class UpdateDriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDriverForm));
            TableLayoutPanelActions = new TableLayoutPanel();
            ButtonExit = new Button();
            ButtonUpdate = new Button();
            GroupBoxActions = new GroupBox();
            TableLayoutPanelDriverInfo = new TableLayoutPanel();
            TableLayoutPanelMain = new TableLayoutPanel();
            GroupBoxParameters = new GroupBox();
            TableLayoutPanelDriverParameters = new TableLayoutPanel();
            LabelFirstName = new Label();
            LabelLastName = new Label();
            LabelAge = new Label();
            LabelDrivingExperience = new Label();
            LabelTransport = new Label();
            GroupBoxParametersValues = new GroupBox();
            TableLayoutPanelDriverParametersValue = new TableLayoutPanel();
            TextBoxFirstName = new TextBox();
            TextBoxLastName = new TextBox();
            NumericUpDownAge = new NumericUpDown();
            NumericUpDownDrivingExperience = new NumericUpDown();
            ComboBoxTransport = new ComboBox();
            TransportBindingSource = new BindingSource(components);
            RouteBindingSource = new BindingSource(components);
            TableLayoutPanelActions.SuspendLayout();
            GroupBoxActions.SuspendLayout();
            TableLayoutPanelDriverInfo.SuspendLayout();
            TableLayoutPanelMain.SuspendLayout();
            GroupBoxParameters.SuspendLayout();
            TableLayoutPanelDriverParameters.SuspendLayout();
            GroupBoxParametersValues.SuspendLayout();
            TableLayoutPanelDriverParametersValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownDrivingExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransportBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RouteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanelActions
            // 
            TableLayoutPanelActions.BackColor = Color.FromArgb(130, 112, 129);
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
            TableLayoutPanelDriverInfo.TabIndex = 3;
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
            TableLayoutPanelDriverParameters.Controls.Add(LabelFirstName, 0, 0);
            TableLayoutPanelDriverParameters.Controls.Add(LabelLastName, 0, 1);
            TableLayoutPanelDriverParameters.Controls.Add(LabelAge, 0, 2);
            TableLayoutPanelDriverParameters.Controls.Add(LabelDrivingExperience, 0, 3);
            TableLayoutPanelDriverParameters.Controls.Add(LabelTransport, 0, 4);
            TableLayoutPanelDriverParameters.Dock = DockStyle.Fill;
            TableLayoutPanelDriverParameters.Location = new Point(2, 18);
            TableLayoutPanelDriverParameters.Margin = new Padding(2);
            TableLayoutPanelDriverParameters.Name = "TableLayoutPanelDriverParameters";
            TableLayoutPanelDriverParameters.RowCount = 5;
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParameters.Size = new Size(382, 449);
            TableLayoutPanelDriverParameters.TabIndex = 0;
            // 
            // LabelFirstName
            // 
            LabelFirstName.Anchor = AnchorStyles.None;
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(177, 36);
            LabelFirstName.Margin = new Padding(2, 0, 2, 0);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(28, 16);
            LabelFirstName.TabIndex = 0;
            LabelFirstName.Text = "Имя";
            // 
            // LabelLastName
            // 
            LabelLastName.Anchor = AnchorStyles.None;
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(163, 125);
            LabelLastName.Margin = new Padding(2, 0, 2, 0);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(56, 16);
            LabelLastName.TabIndex = 1;
            LabelLastName.Text = "Фамилия";
            // 
            // LabelAge
            // 
            LabelAge.Anchor = AnchorStyles.None;
            LabelAge.AutoSize = true;
            LabelAge.Location = new Point(163, 214);
            LabelAge.Margin = new Padding(2, 0, 2, 0);
            LabelAge.Name = "LabelAge";
            LabelAge.Size = new Size(56, 16);
            LabelAge.TabIndex = 2;
            LabelAge.Text = "Возраст";
            // 
            // LabelDrivingExperience
            // 
            LabelDrivingExperience.Anchor = AnchorStyles.None;
            LabelDrivingExperience.AutoSize = true;
            LabelDrivingExperience.Location = new Point(142, 303);
            LabelDrivingExperience.Margin = new Padding(2, 0, 2, 0);
            LabelDrivingExperience.Name = "LabelDrivingExperience";
            LabelDrivingExperience.Size = new Size(98, 16);
            LabelDrivingExperience.TabIndex = 3;
            LabelDrivingExperience.Text = "Опыт вождения";
            // 
            // LabelTransport
            // 
            LabelTransport.Anchor = AnchorStyles.None;
            LabelTransport.AutoSize = true;
            LabelTransport.Location = new Point(156, 394);
            LabelTransport.Margin = new Padding(2, 0, 2, 0);
            LabelTransport.Name = "LabelTransport";
            LabelTransport.Size = new Size(70, 16);
            LabelTransport.TabIndex = 4;
            LabelTransport.Text = "Транспорт";
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
            TableLayoutPanelDriverParametersValue.Controls.Add(TextBoxFirstName, 0, 0);
            TableLayoutPanelDriverParametersValue.Controls.Add(TextBoxLastName, 0, 1);
            TableLayoutPanelDriverParametersValue.Controls.Add(NumericUpDownAge, 0, 2);
            TableLayoutPanelDriverParametersValue.Controls.Add(NumericUpDownDrivingExperience, 0, 3);
            TableLayoutPanelDriverParametersValue.Controls.Add(ComboBoxTransport, 0, 4);
            TableLayoutPanelDriverParametersValue.Dock = DockStyle.Fill;
            TableLayoutPanelDriverParametersValue.Location = new Point(2, 18);
            TableLayoutPanelDriverParametersValue.Margin = new Padding(2);
            TableLayoutPanelDriverParametersValue.Name = "TableLayoutPanelDriverParametersValue";
            TableLayoutPanelDriverParametersValue.RowCount = 5;
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParametersValue.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableLayoutPanelDriverParametersValue.Size = new Size(382, 449);
            TableLayoutPanelDriverParametersValue.TabIndex = 0;
            // 
            // TextBoxFirstName
            // 
            TextBoxFirstName.Anchor = AnchorStyles.None;
            TextBoxFirstName.BackColor = Color.FromArgb(198, 210, 237);
            TextBoxFirstName.Location = new Point(41, 33);
            TextBoxFirstName.Margin = new Padding(2);
            TextBoxFirstName.Name = "TextBoxFirstName";
            TextBoxFirstName.Size = new Size(300, 23);
            TextBoxFirstName.TabIndex = 0;
            // 
            // TextBoxLastName
            // 
            TextBoxLastName.Anchor = AnchorStyles.None;
            TextBoxLastName.BackColor = Color.FromArgb(198, 210, 237);
            TextBoxLastName.Location = new Point(41, 122);
            TextBoxLastName.Margin = new Padding(2);
            TextBoxLastName.Name = "TextBoxLastName";
            TextBoxLastName.Size = new Size(300, 23);
            TextBoxLastName.TabIndex = 1;
            // 
            // NumericUpDownAge
            // 
            NumericUpDownAge.Anchor = AnchorStyles.None;
            NumericUpDownAge.BackColor = Color.FromArgb(198, 210, 237);
            NumericUpDownAge.Location = new Point(41, 211);
            NumericUpDownAge.Margin = new Padding(2);
            NumericUpDownAge.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            NumericUpDownAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            NumericUpDownAge.Name = "NumericUpDownAge";
            NumericUpDownAge.Size = new Size(300, 23);
            NumericUpDownAge.TabIndex = 5;
            NumericUpDownAge.TextAlign = HorizontalAlignment.Center;
            NumericUpDownAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // NumericUpDownDrivingExperience
            // 
            NumericUpDownDrivingExperience.Anchor = AnchorStyles.None;
            NumericUpDownDrivingExperience.BackColor = Color.FromArgb(198, 210, 237);
            NumericUpDownDrivingExperience.Location = new Point(41, 300);
            NumericUpDownDrivingExperience.Margin = new Padding(2);
            NumericUpDownDrivingExperience.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumericUpDownDrivingExperience.Name = "NumericUpDownDrivingExperience";
            NumericUpDownDrivingExperience.Size = new Size(300, 23);
            NumericUpDownDrivingExperience.TabIndex = 6;
            NumericUpDownDrivingExperience.TextAlign = HorizontalAlignment.Center;
            // 
            // ComboBoxTransport
            // 
            ComboBoxTransport.Anchor = AnchorStyles.None;
            ComboBoxTransport.BackColor = Color.FromArgb(198, 210, 237);
            ComboBoxTransport.DataSource = TransportBindingSource;
            ComboBoxTransport.DisplayMember = "Model";
            ComboBoxTransport.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTransport.FormattingEnabled = true;
            ComboBoxTransport.Location = new Point(41, 391);
            ComboBoxTransport.Margin = new Padding(2);
            ComboBoxTransport.Name = "ComboBoxTransport";
            ComboBoxTransport.Size = new Size(300, 24);
            ComboBoxTransport.TabIndex = 7;
            // 
            // TransportBindingSource
            // 
            TransportBindingSource.DataSource = typeof(Entities.Transport);
            // 
            // RouteBindingSource
            // 
            RouteBindingSource.DataSource = typeof(Entities.Route);
            // 
            // UpdateDriverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(130, 112, 129);
            ClientSize = new Size(784, 565);
            Controls.Add(TableLayoutPanelDriverInfo);
            Font = new Font("JetBrainsMono Nerd Font", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 600);
            Name = "UpdateDriverForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменить параметры водителя";
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
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownDrivingExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransportBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)RouteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelActions;
        private Button ButtonExit;
        private Button ButtonUpdate;
        private GroupBox GroupBoxActions;
        private TableLayoutPanel TableLayoutPanelDriverInfo;
        private TableLayoutPanel TableLayoutPanelMain;
        private GroupBox GroupBoxParameters;
        private TableLayoutPanel TableLayoutPanelDriverParameters;
        private Label LabelFirstName;
        private Label LabelLastName;
        private Label LabelAge;
        private Label LabelDrivingExperience;
        private Label LabelTransport;
        private GroupBox GroupBoxParametersValues;
        private TableLayoutPanel TableLayoutPanelDriverParametersValue;
        private TextBox TextBoxFirstName;
        private TextBox TextBoxLastName;
        private NumericUpDown NumericUpDownAge;
        private NumericUpDown NumericUpDownDrivingExperience;
        private ComboBox ComboBoxTransport;
        private BindingSource TransportBindingSource;
        private BindingSource RouteBindingSource;
    }
}