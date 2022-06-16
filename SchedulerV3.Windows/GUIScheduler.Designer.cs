namespace SchedulerV3.Windows
{
    partial class GuiScheduler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.currentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calculateButton = new System.Windows.Forms.Button();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.onceTimeAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.occursComboBox = new System.Windows.Forms.ComboBox();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.occursLabel = new System.Windows.Forms.Label();
            this.oceTimeAtLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.monthlyConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.theRadioButton = new System.Windows.Forms.RadioButton();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.ofEveryUpDown = new System.Windows.Forms.NumericUpDown();
            this.months2Llabel = new System.Windows.Forms.Label();
            this.ofEveryLabel = new System.Windows.Forms.Label();
            this.monthDaysComboBox = new System.Windows.Forms.ComboBox();
            this.monthFrecuencyComboBox = new System.Windows.Forms.ComboBox();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.everyUpDown = new System.Windows.Forms.NumericUpDown();
            this.everyLabel = new System.Windows.Forms.Label();
            this.numDaysUpDown = new System.Windows.Forms.NumericUpDown();
            this.dailyFrequencyGroupBox = new System.Windows.Forms.GroupBox();
            this.occursEveryRadioButton = new System.Windows.Forms.RadioButton();
            this.occursOnceAtRadioButton = new System.Windows.Forms.RadioButton();
            this.endingAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endAtLabel = new System.Windows.Forms.Label();
            this.startingAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.occursEveryComboBox = new System.Windows.Forms.ComboBox();
            this.occursEveryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.occursOnceAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startingAtLabel = new System.Windows.Forms.Label();
            this.limitsGroupBox = new System.Windows.Forms.GroupBox();
            this.endLimitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLimitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nextExecutionTimeTextBox = new System.Windows.Forms.TextBox();
            this.nextExecutionTimeLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            this.monthlyConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofEveryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.everyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysUpDown)).BeginInit();
            this.dailyFrequencyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occursEveryNumericUpDown)).BeginInit();
            this.limitsGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.currentDateDateTimePicker);
            this.inputGroupBox.Controls.Add(this.calculateButton);
            this.inputGroupBox.Controls.Add(this.currentDateLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(662, 66);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // currentDateDateTimePicker
            // 
            this.currentDateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.currentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currentDateDateTimePicker.Location = new System.Drawing.Point(85, 24);
            this.currentDateDateTimePicker.Name = "currentDateDateTimePicker";
            this.currentDateDateTimePicker.Size = new System.Drawing.Size(207, 23);
            this.currentDateDateTimePicker.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(298, 26);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(358, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate next date";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.FillSettings);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(6, 29);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(73, 15);
            this.currentDateLabel.TabIndex = 0;
            this.currentDateLabel.Text = "Current date";
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.onceTimeAtDateTimePicker);
            this.configurationGroupBox.Controls.Add(this.occursComboBox);
            this.configurationGroupBox.Controls.Add(this.enabledCheckBox);
            this.configurationGroupBox.Controls.Add(this.typeComboBox);
            this.configurationGroupBox.Controls.Add(this.occursLabel);
            this.configurationGroupBox.Controls.Add(this.oceTimeAtLabel);
            this.configurationGroupBox.Controls.Add(this.typeLabel);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 84);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(662, 112);
            this.configurationGroupBox.TabIndex = 1;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // onceTimeAtDateTimePicker
            // 
            this.onceTimeAtDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.onceTimeAtDateTimePicker.Enabled = false;
            this.onceTimeAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.onceTimeAtDateTimePicker.Location = new System.Drawing.Point(85, 53);
            this.onceTimeAtDateTimePicker.Name = "onceTimeAtDateTimePicker";
            this.onceTimeAtDateTimePicker.Size = new System.Drawing.Size(571, 23);
            this.onceTimeAtDateTimePicker.TabIndex = 7;
            // 
            // occursComboBox
            // 
            this.occursComboBox.Enabled = false;
            this.occursComboBox.FormattingEnabled = true;
            this.occursComboBox.Items.AddRange(new object[] {
            "Daily",
            "Monthly"});
            this.occursComboBox.Location = new System.Drawing.Point(85, 78);
            this.occursComboBox.Name = "occursComboBox";
            this.occursComboBox.Size = new System.Drawing.Size(571, 23);
            this.occursComboBox.TabIndex = 6;
            this.occursComboBox.SelectedIndexChanged += new System.EventHandler(this.OccursComboBox_SelectedIndexChanged);
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Checked = true;
            this.enabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckBox.Location = new System.Drawing.Point(298, 30);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(68, 19);
            this.enabledCheckBox.TabIndex = 4;
            this.enabledCheckBox.Text = "Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Once",
            "Recurring"});
            this.typeComboBox.Location = new System.Drawing.Point(85, 26);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(207, 23);
            this.typeComboBox.TabIndex = 3;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // occursLabel
            // 
            this.occursLabel.AutoSize = true;
            this.occursLabel.Location = new System.Drawing.Point(6, 78);
            this.occursLabel.Name = "occursLabel";
            this.occursLabel.Size = new System.Drawing.Size(44, 15);
            this.occursLabel.TabIndex = 2;
            this.occursLabel.Text = "Occurs";
            // 
            // oceTimeAtLabel
            // 
            this.oceTimeAtLabel.AutoSize = true;
            this.oceTimeAtLabel.Location = new System.Drawing.Point(6, 53);
            this.oceTimeAtLabel.Name = "oceTimeAtLabel";
            this.oceTimeAtLabel.Size = new System.Drawing.Size(75, 15);
            this.oceTimeAtLabel.TabIndex = 1;
            this.oceTimeAtLabel.Text = "Once time at";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 29);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 15);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type";
            // 
            // monthlyConfigurationGroupBox
            // 
            this.monthlyConfigurationGroupBox.Controls.Add(this.theRadioButton);
            this.monthlyConfigurationGroupBox.Controls.Add(this.dayRadioButton);
            this.monthlyConfigurationGroupBox.Controls.Add(this.ofEveryUpDown);
            this.monthlyConfigurationGroupBox.Controls.Add(this.months2Llabel);
            this.monthlyConfigurationGroupBox.Controls.Add(this.ofEveryLabel);
            this.monthlyConfigurationGroupBox.Controls.Add(this.monthDaysComboBox);
            this.monthlyConfigurationGroupBox.Controls.Add(this.monthFrecuencyComboBox);
            this.monthlyConfigurationGroupBox.Controls.Add(this.monthsLabel);
            this.monthlyConfigurationGroupBox.Controls.Add(this.everyUpDown);
            this.monthlyConfigurationGroupBox.Controls.Add(this.everyLabel);
            this.monthlyConfigurationGroupBox.Controls.Add(this.numDaysUpDown);
            this.monthlyConfigurationGroupBox.Location = new System.Drawing.Point(12, 202);
            this.monthlyConfigurationGroupBox.Name = "monthlyConfigurationGroupBox";
            this.monthlyConfigurationGroupBox.Size = new System.Drawing.Size(662, 100);
            this.monthlyConfigurationGroupBox.TabIndex = 2;
            this.monthlyConfigurationGroupBox.TabStop = false;
            this.monthlyConfigurationGroupBox.Text = "Monthly Configuration";
            // 
            // theRadioButton
            // 
            this.theRadioButton.AutoSize = true;
            this.theRadioButton.Location = new System.Drawing.Point(5, 64);
            this.theRadioButton.Name = "theRadioButton";
            this.theRadioButton.Size = new System.Drawing.Size(44, 19);
            this.theRadioButton.TabIndex = 12;
            this.theRadioButton.TabStop = true;
            this.theRadioButton.Text = "The";
            this.theRadioButton.UseVisualStyleBackColor = true;
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(6, 22);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(45, 19);
            this.dayRadioButton.TabIndex = 11;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "Day";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            // 
            // ofEveryUpDown
            // 
            this.ofEveryUpDown.Location = new System.Drawing.Point(494, 66);
            this.ofEveryUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ofEveryUpDown.Name = "ofEveryUpDown";
            this.ofEveryUpDown.ReadOnly = true;
            this.ofEveryUpDown.Size = new System.Drawing.Size(98, 23);
            this.ofEveryUpDown.TabIndex = 10;
            this.ofEveryUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // months2Llabel
            // 
            this.months2Llabel.AutoSize = true;
            this.months2Llabel.Location = new System.Drawing.Point(598, 72);
            this.months2Llabel.Name = "months2Llabel";
            this.months2Llabel.Size = new System.Drawing.Size(56, 15);
            this.months2Llabel.TabIndex = 9;
            this.months2Llabel.Text = "month(s)";
            // 
            // ofEveryLabel
            // 
            this.ofEveryLabel.AutoSize = true;
            this.ofEveryLabel.Location = new System.Drawing.Point(437, 70);
            this.ofEveryLabel.Name = "ofEveryLabel";
            this.ofEveryLabel.Size = new System.Drawing.Size(51, 15);
            this.ofEveryLabel.TabIndex = 8;
            this.ofEveryLabel.Text = "Of every";
            // 
            // monthDaysComboBox
            // 
            this.monthDaysComboBox.Enabled = false;
            this.monthDaysComboBox.FormattingEnabled = true;
            this.monthDaysComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            "Day",
            "Weekday",
            "Weekend Day"});
            this.monthDaysComboBox.Location = new System.Drawing.Point(310, 64);
            this.monthDaysComboBox.Name = "monthDaysComboBox";
            this.monthDaysComboBox.Size = new System.Drawing.Size(121, 23);
            this.monthDaysComboBox.TabIndex = 7;
            // 
            // monthFrecuencyComboBox
            // 
            this.monthFrecuencyComboBox.Enabled = false;
            this.monthFrecuencyComboBox.FormattingEnabled = true;
            this.monthFrecuencyComboBox.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Last"});
            this.monthFrecuencyComboBox.Location = new System.Drawing.Point(184, 64);
            this.monthFrecuencyComboBox.Name = "monthFrecuencyComboBox";
            this.monthFrecuencyComboBox.Size = new System.Drawing.Size(121, 23);
            this.monthFrecuencyComboBox.TabIndex = 6;
            // 
            // monthsLabel
            // 
            this.monthsLabel.AutoSize = true;
            this.monthsLabel.Location = new System.Drawing.Point(349, 24);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(56, 15);
            this.monthsLabel.TabIndex = 4;
            this.monthsLabel.Text = "month(s)";
            // 
            // everyUpDown
            // 
            this.everyUpDown.Location = new System.Drawing.Point(264, 22);
            this.everyUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.everyUpDown.Name = "everyUpDown";
            this.everyUpDown.ReadOnly = true;
            this.everyUpDown.Size = new System.Drawing.Size(79, 23);
            this.everyUpDown.TabIndex = 3;
            this.everyUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // everyLabel
            // 
            this.everyLabel.AutoSize = true;
            this.everyLabel.Location = new System.Drawing.Point(184, 24);
            this.everyLabel.Name = "everyLabel";
            this.everyLabel.Size = new System.Drawing.Size(35, 15);
            this.everyLabel.TabIndex = 2;
            this.everyLabel.Text = "Every";
            // 
            // numDaysUpDown
            // 
            this.numDaysUpDown.Location = new System.Drawing.Point(95, 22);
            this.numDaysUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDaysUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDaysUpDown.Name = "numDaysUpDown";
            this.numDaysUpDown.ReadOnly = true;
            this.numDaysUpDown.Size = new System.Drawing.Size(83, 23);
            this.numDaysUpDown.TabIndex = 1;
            this.numDaysUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dailyFrequencyGroupBox
            // 
            this.dailyFrequencyGroupBox.Controls.Add(this.occursEveryRadioButton);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursOnceAtRadioButton);
            this.dailyFrequencyGroupBox.Controls.Add(this.endingAtDateTimePicker);
            this.dailyFrequencyGroupBox.Controls.Add(this.endAtLabel);
            this.dailyFrequencyGroupBox.Controls.Add(this.startingAtDateTimePicker);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursEveryComboBox);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursEveryNumericUpDown);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursOnceAtDateTimePicker);
            this.dailyFrequencyGroupBox.Controls.Add(this.startingAtLabel);
            this.dailyFrequencyGroupBox.Location = new System.Drawing.Point(12, 308);
            this.dailyFrequencyGroupBox.Name = "dailyFrequencyGroupBox";
            this.dailyFrequencyGroupBox.Size = new System.Drawing.Size(662, 126);
            this.dailyFrequencyGroupBox.TabIndex = 3;
            this.dailyFrequencyGroupBox.TabStop = false;
            this.dailyFrequencyGroupBox.Text = "Daily Frequency";
            // 
            // occursEveryRadioButton
            // 
            this.occursEveryRadioButton.AutoSize = true;
            this.occursEveryRadioButton.Location = new System.Drawing.Point(6, 56);
            this.occursEveryRadioButton.Name = "occursEveryRadioButton";
            this.occursEveryRadioButton.Size = new System.Drawing.Size(93, 19);
            this.occursEveryRadioButton.TabIndex = 10;
            this.occursEveryRadioButton.TabStop = true;
            this.occursEveryRadioButton.Text = "Occurs every";
            this.occursEveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // occursOnceAtRadioButton
            // 
            this.occursOnceAtRadioButton.AutoSize = true;
            this.occursOnceAtRadioButton.Location = new System.Drawing.Point(6, 31);
            this.occursOnceAtRadioButton.Name = "occursOnceAtRadioButton";
            this.occursOnceAtRadioButton.Size = new System.Drawing.Size(104, 19);
            this.occursOnceAtRadioButton.TabIndex = 9;
            this.occursOnceAtRadioButton.TabStop = true;
            this.occursOnceAtRadioButton.Text = "Occurs once at";
            this.occursOnceAtRadioButton.UseVisualStyleBackColor = true;
            // 
            // endingAtDateTimePicker
            // 
            this.endingAtDateTimePicker.Enabled = false;
            this.endingAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endingAtDateTimePicker.Location = new System.Drawing.Point(228, 84);
            this.endingAtDateTimePicker.Name = "endingAtDateTimePicker";
            this.endingAtDateTimePicker.ShowUpDown = true;
            this.endingAtDateTimePicker.Size = new System.Drawing.Size(156, 23);
            this.endingAtDateTimePicker.TabIndex = 8;
            this.endingAtDateTimePicker.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // endAtLabel
            // 
            this.endAtLabel.AutoSize = true;
            this.endAtLabel.Location = new System.Drawing.Point(184, 87);
            this.endAtLabel.Name = "endAtLabel";
            this.endAtLabel.Size = new System.Drawing.Size(40, 15);
            this.endAtLabel.TabIndex = 7;
            this.endAtLabel.Text = "End at";
            // 
            // startingAtDateTimePicker
            // 
            this.startingAtDateTimePicker.Enabled = false;
            this.startingAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startingAtDateTimePicker.Location = new System.Drawing.Point(64, 84);
            this.startingAtDateTimePicker.Name = "startingAtDateTimePicker";
            this.startingAtDateTimePicker.ShowUpDown = true;
            this.startingAtDateTimePicker.Size = new System.Drawing.Size(114, 23);
            this.startingAtDateTimePicker.TabIndex = 6;
            this.startingAtDateTimePicker.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // occursEveryComboBox
            // 
            this.occursEveryComboBox.Enabled = false;
            this.occursEveryComboBox.FormattingEnabled = true;
            this.occursEveryComboBox.Items.AddRange(new object[] {
            "Hours",
            "Minutes",
            "Seconds"});
            this.occursEveryComboBox.Location = new System.Drawing.Point(310, 55);
            this.occursEveryComboBox.Name = "occursEveryComboBox";
            this.occursEveryComboBox.Size = new System.Drawing.Size(74, 23);
            this.occursEveryComboBox.TabIndex = 5;
            // 
            // occursEveryNumericUpDown
            // 
            this.occursEveryNumericUpDown.Location = new System.Drawing.Point(184, 55);
            this.occursEveryNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.occursEveryNumericUpDown.Name = "occursEveryNumericUpDown";
            this.occursEveryNumericUpDown.ReadOnly = true;
            this.occursEveryNumericUpDown.Size = new System.Drawing.Size(126, 23);
            this.occursEveryNumericUpDown.TabIndex = 4;
            this.occursEveryNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // occursOnceAtDateTimePicker
            // 
            this.occursOnceAtDateTimePicker.Enabled = false;
            this.occursOnceAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.occursOnceAtDateTimePicker.Location = new System.Drawing.Point(184, 27);
            this.occursOnceAtDateTimePicker.Name = "occursOnceAtDateTimePicker";
            this.occursOnceAtDateTimePicker.ShowUpDown = true;
            this.occursOnceAtDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.occursOnceAtDateTimePicker.TabIndex = 3;
            this.occursOnceAtDateTimePicker.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // startingAtLabel
            // 
            this.startingAtLabel.AutoSize = true;
            this.startingAtLabel.Location = new System.Drawing.Point(6, 87);
            this.startingAtLabel.Name = "startingAtLabel";
            this.startingAtLabel.Size = new System.Drawing.Size(61, 15);
            this.startingAtLabel.TabIndex = 2;
            this.startingAtLabel.Text = "Starting at";
            // 
            // limitsGroupBox
            // 
            this.limitsGroupBox.Controls.Add(this.endLimitDateTimePicker);
            this.limitsGroupBox.Controls.Add(this.startLimitDateTimePicker);
            this.limitsGroupBox.Controls.Add(this.endDateLabel);
            this.limitsGroupBox.Controls.Add(this.startDateLabel);
            this.limitsGroupBox.Location = new System.Drawing.Point(12, 440);
            this.limitsGroupBox.Name = "limitsGroupBox";
            this.limitsGroupBox.Size = new System.Drawing.Size(662, 60);
            this.limitsGroupBox.TabIndex = 4;
            this.limitsGroupBox.TabStop = false;
            this.limitsGroupBox.Text = "Limits";
            // 
            // endLimitDateTimePicker
            // 
            this.endLimitDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.endLimitDateTimePicker.Enabled = false;
            this.endLimitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endLimitDateTimePicker.Location = new System.Drawing.Point(383, 20);
            this.endLimitDateTimePicker.Name = "endLimitDateTimePicker";
            this.endLimitDateTimePicker.Size = new System.Drawing.Size(273, 23);
            this.endLimitDateTimePicker.TabIndex = 5;
            // 
            // startLimitDateTimePicker
            // 
            this.startLimitDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.startLimitDateTimePicker.Enabled = false;
            this.startLimitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startLimitDateTimePicker.Location = new System.Drawing.Point(95, 22);
            this.startLimitDateTimePicker.Name = "startLimitDateTimePicker";
            this.startLimitDateTimePicker.Size = new System.Drawing.Size(138, 23);
            this.startLimitDateTimePicker.TabIndex = 4;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(230, 28);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(53, 15);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "End date";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 28);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(57, 15);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start date";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.descriptionTextBox);
            this.outputGroupBox.Controls.Add(this.descriptionLabel);
            this.outputGroupBox.Controls.Add(this.nextExecutionTimeTextBox);
            this.outputGroupBox.Controls.Add(this.nextExecutionTimeLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 506);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(662, 124);
            this.outputGroupBox.TabIndex = 5;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 73);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(650, 45);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // nextExecutionTimeTextBox
            // 
            this.nextExecutionTimeTextBox.Location = new System.Drawing.Point(124, 25);
            this.nextExecutionTimeTextBox.Name = "nextExecutionTimeTextBox";
            this.nextExecutionTimeTextBox.ReadOnly = true;
            this.nextExecutionTimeTextBox.Size = new System.Drawing.Size(532, 23);
            this.nextExecutionTimeTextBox.TabIndex = 1;
            // 
            // nextExecutionTimeLabel
            // 
            this.nextExecutionTimeLabel.AutoSize = true;
            this.nextExecutionTimeLabel.Location = new System.Drawing.Point(6, 28);
            this.nextExecutionTimeLabel.Name = "nextExecutionTimeLabel";
            this.nextExecutionTimeLabel.Size = new System.Drawing.Size(114, 15);
            this.nextExecutionTimeLabel.TabIndex = 0;
            this.nextExecutionTimeLabel.Text = "Next execution time";
            // 
            // GUIScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 639);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.limitsGroupBox);
            this.Controls.Add(this.dailyFrequencyGroupBox);
            this.Controls.Add(this.monthlyConfigurationGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "GuiScheduler";
            this.Text = "Scheduler";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            this.monthlyConfigurationGroupBox.ResumeLayout(false);
            this.monthlyConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofEveryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.everyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysUpDown)).EndInit();
            this.dailyFrequencyGroupBox.ResumeLayout(false);
            this.dailyFrequencyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occursEveryNumericUpDown)).EndInit();
            this.limitsGroupBox.ResumeLayout(false);
            this.limitsGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox inputGroupBox;
        private Button calculateButton;
        private Label currentDateLabel;
        private GroupBox configurationGroupBox;
        private ComboBox occursComboBox;
        private CheckBox enabledCheckBox;
        private ComboBox typeComboBox;
        private Label occursLabel;
        private Label oceTimeAtLabel;
        private Label typeLabel;
        private GroupBox monthlyConfigurationGroupBox;
        private GroupBox dailyFrequencyGroupBox;
        private DateTimePicker endingAtDateTimePicker;
        private Label endAtLabel;
        private DateTimePicker startingAtDateTimePicker;
        private ComboBox occursEveryComboBox;
        private NumericUpDown occursEveryNumericUpDown;
        private DateTimePicker occursOnceAtDateTimePicker;
        private Label startingAtLabel;
        private GroupBox limitsGroupBox;
        private Label endDateLabel;
        private Label startDateLabel;
        private GroupBox outputGroupBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox nextExecutionTimeTextBox;
        private Label nextExecutionTimeLabel;
        private RadioButton occursEveryRadioButton;
        private RadioButton occursOnceAtRadioButton;
        private DateTimePicker currentDateDateTimePicker;
        private DateTimePicker onceTimeAtDateTimePicker;
        private DateTimePicker endLimitDateTimePicker;
        private DateTimePicker startLimitDateTimePicker;
        private Label everyLabel;
        private NumericUpDown numDaysUpDown;
        private NumericUpDown ofEveryUpDown;
        private Label months2Llabel;
        private Label ofEveryLabel;
        private ComboBox monthDaysComboBox;
        private ComboBox monthFrecuencyComboBox;
        private Label monthsLabel;
        private NumericUpDown everyUpDown;
        private RadioButton theRadioButton;
        private RadioButton dayRadioButton;
    }
}