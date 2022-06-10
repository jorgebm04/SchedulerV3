namespace SchedulerV3.Windows
{
    public partial class GUIScheduler : Form
    {
        public GUIScheduler()
        {
            InitializeComponent();
        }

        private void FillSettings(object sender, EventArgs e)
        {
            nextExecutionTimeTextBox.Text = "";
            descriptionTextBox.Text = "";
            Settings settings = new Settings
            {
                currentDate = currentDateDateTimePicker.Value,
                type = typeComboBox.SelectedIndex,
                onceTimeAt = onceTimeAtDateTimePicker.Value,
                occurs = occursComboBox.SelectedIndex,
                day = dayRadioButton.Checked,
                numDay = (int)numDaysUpDown.Value,
                numMonths = (int)everyUpDown.Value,
                the = theRadioButton.Checked,
                monthlyFreq = monthFrecuencyComboBox.SelectedIndex,
                dailyFreq = monthDaysComboBox.SelectedIndex,
                monthly2Freq = (int)ofEveryUpDown.Value,
                occursOnceAt = occursOnceAtRadioButton.Checked,
                occursOnceAtHour = occursOnceAtDateTimePicker.Value,
                occursEvery = occursEveryRadioButton.Checked,
                occursEveryFreq = (int)occursEveryNumericUpDown.Value,
                freq = occursEveryComboBox.SelectedIndex,
                startingHour = startingAtDateTimePicker.Value,
                endingHour = endingAtDateTimePicker.Value,
                startingLimit = startLimitDateTimePicker.Value,
                endingLimit = endLimitDateTimePicker.Value,
                freqTime = occursEveryComboBox.Text,
                isOverLimit = false
            };
            CheckSettings(settings);
        }
        public void CheckSettings(Settings settings)
        {
            if (!enabledCheckBox.Checked)
            {
                nextExecutionTimeTextBox.Text = "Scheduler not enabled";
                return;
            }
            switch (settings.type)
            {
                case (int)TypeEnum.Types.Once:
                    CheckOnceSettings.CheckSettings(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CheckRecurringSettings.CheckSettings(settings);
                    break;
                default:
                    settings.nextExecutionTime = "Please select a type";
                    break;
            }
            nextExecutionTimeTextBox.Text = settings.nextExecutionTime;
            if (settings.nextExecutionTime.Length == 0)
            {
                CalculateNextDate(settings);
            }
        }

        public void CalculateNextDate(Settings settings)
        {
            switch (settings.type)
            {
                case (int)TypeEnum.Types.Once:
                    CalculateOnce.CalculateNextExecutionTime(settings);
                    OnceDescription.SetDescription(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CalculateRecurring.calculate(settings);
                    break;
                default:
                    break;
            }
            nextExecutionTimeTextBox.Text = settings.nextExecutionTime;
            descriptionTextBox.Text = settings.description;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                onceTimeAtDateTimePicker.Enabled = true;
                occursComboBox.Enabled = false;
                numDaysUpDown.ReadOnly = true;
                everyUpDown.ReadOnly = true;
                monthFrecuencyComboBox.Enabled = false;
                monthDaysComboBox.Enabled = false;
                ofEveryUpDown.ReadOnly = true;
                occursOnceAtDateTimePicker.Enabled = false;
                occursEveryNumericUpDown.ReadOnly = true;
                occursEveryComboBox.Enabled = false;
                startingAtDateTimePicker.Enabled = false;
                endingAtDateTimePicker.Enabled = false;
                startLimitDateTimePicker.Enabled = false;
                endLimitDateTimePicker.Enabled = false;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = false;
                everyUpDown.ReadOnly = false;
                monthFrecuencyComboBox.Enabled = true;
                monthDaysComboBox.Enabled = true;
                ofEveryUpDown.ReadOnly = false;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
        }
        
        private void occursComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(occursComboBox.SelectedIndex == 0)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = true;
                everyUpDown.ReadOnly = true;
                monthFrecuencyComboBox.Enabled = false;
                monthDaysComboBox.Enabled = false;
                ofEveryUpDown.ReadOnly = true;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                occursComboBox.Enabled = true;
                numDaysUpDown.ReadOnly = false;
                everyUpDown.ReadOnly = false;
                monthFrecuencyComboBox.Enabled = true;
                monthDaysComboBox.Enabled = true;
                ofEveryUpDown.ReadOnly = false;
                occursOnceAtDateTimePicker.Enabled = true;
                occursEveryNumericUpDown.ReadOnly = false;
                occursEveryComboBox.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
        }
    }
}