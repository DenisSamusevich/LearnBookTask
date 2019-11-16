using System;
using System.Windows.Forms;

namespace Task011
{
    public partial class Form1 : Form
    {
        private DateTime timeStartStopwacht;
        private DateTime timeEndStopwacht;
        public Form1()
        {
            InitializeComponent();

            numericUpDownInputMinutes.Maximum = 59;
            numericUpDownInputMinutes.Minimum = 0;
            numericUpDownInputMinutes.TabStop = false;

            numericUpDownInputSeconds.Maximum = 59;
            numericUpDownInputSeconds.Minimum = 0;
            numericUpDownInputSeconds.TabStop = false;

            buttonStartStopwacht.Enabled = false;
        }

        private void numericUpDownInput_ValueChanged(object sender, EventArgs e)
        {
            if((numericUpDownInputMinutes.Value==0)&& (numericUpDownInputSeconds.Value == 0))
            {
                buttonStartStopwacht.Enabled = false;
            }
            else
            {
                buttonStartStopwacht.Enabled = true;
            }
        }

        private void buttonStartStopwacht_Click(object sender, EventArgs e)
        {
            if (!timerStopwacht.Enabled)
            {
                timeStartStopwacht = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                timeEndStopwacht = timeStartStopwacht.AddMinutes((double)numericUpDownInputMinutes.Value);
                timeEndStopwacht = timeEndStopwacht.AddSeconds((double)numericUpDownInputSeconds.Value);

                groupBoxOutputResult.Enabled = false;
                buttonStartStopwacht.Text = "Стоп";
                labelResultStopwacht.Text = timeEndStopwacht.Minute.ToString("d2") + ":" + timeEndStopwacht.Second.ToString("d2");
                timerStopwacht.Interval = 1000;
                timerStopwacht.Enabled = true;
                groupBoxOutputResult.Visible = false;
            }
            else
            {
                timerStopwacht.Enabled = false;
                buttonStartStopwacht.Text = "Пуск";
                groupBoxOutputResult.Enabled = true;
                numericUpDownInputMinutes.Value = timeEndStopwacht.Minute;
                numericUpDownInputSeconds.Value = timeEndStopwacht.Second;
                groupBoxOutputResult.Visible = true;
            }
        }

        private void timerStopwacht_Tick(object sender, EventArgs e)
        {
            timeEndStopwacht = timeEndStopwacht.AddSeconds(-1);
            labelResultStopwacht.Text = timeEndStopwacht.Minute.ToString("d2") + ":" + timeEndStopwacht.Second.ToString("d2");
            if (Equals(timeStartStopwacht, timeEndStopwacht))
            {
                timerStopwacht.Enabled = false;
                MessageBox.Show("Заданый интервал времени истек", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonStartStopwacht.Text = "Пуск";
                groupBoxOutputResult.Enabled = true;
                numericUpDownInputMinutes.Value = 0;
                numericUpDownInputSeconds.Value = 0;
                buttonStartStopwacht.Enabled = false;
            }
        }
    }
}
