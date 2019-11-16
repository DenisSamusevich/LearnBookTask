using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task010
{
    public partial class Form1 : Form
    {
        int minutes;
        int seconds;
        public Form1()
        {
            InitializeComponent();
            timerStopwatch.Interval = 500;
            minutes = 0;
            seconds = 0;
            labelResultMinutes.Text = "00";
            labelResultSeconds.Text = "00";
            labelTextColon.Visible = true;
            buttonReset.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonReset.Enabled = true;
            if (timerStopwatch.Enabled)
            {
                timerStopwatch.Enabled = false;
                buttonStart.Text = "Пуск";
                buttonReset.Enabled = true;
            }
            else
            {
                timerStopwatch.Enabled = true;
                buttonStart.Text = "Cтоп";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            minutes = 0;
            seconds = 0;
            labelResultMinutes.Text = "00";
            labelResultSeconds.Text = "00";
            if (timerStopwatch.Enabled)
            {
                buttonReset.Enabled = true;
            }
            else
            {
                buttonReset.Enabled = false;
            }
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            if (labelTextColon.Visible)
            {
                if (seconds < 59)
                {
                    seconds++;
                    labelResultSeconds.Text = seconds.ToString("d2");
                    
                }
                else
                {
                    if (minutes < 59)
                    {
                        minutes++;
                        labelResultMinutes.Text = minutes.ToString("d2");
                    }
                    else
                    {
                        minutes = 0;
                        labelResultMinutes.Text = "00";
                    }
                    seconds = 0;
                    labelResultSeconds.Text = "00";
                }
                labelTextColon.Visible = false;
            }
            else
            {
                labelTextColon.Visible = true;
            }
        }
    }
}
