using System;
using System.Windows.Forms;

namespace Task005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            labelTextResultPriceCar.Text = string.Empty;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double startPrise =39000;
            double discount = 0;
            double totalPrise;

            if (checkBoxABS.Checked)
            {
                startPrise += 839;
            }
            if (checkBoxFogLights.Checked)
            {
                startPrise += 599;
            }
            if (checkBoxParkingSensors.Checked)
            {
                startPrise += 759;
            }

            totalPrise = startPrise;
            string textTotalPrise = "Цена в выбраной комплектации: " + totalPrise.ToString("N") + " руб.";
            if (checkBoxABS.Checked && checkBoxFogLights.Checked && checkBoxParkingSensors.Checked)
            {
                discount= totalPrise*0.01;
                totalPrise = totalPrise - discount;
                textTotalPrise += "\nСкидка (1%): " +
                    discount.ToString("N") + " руб." +
                    "\nИтого: " + totalPrise.ToString("N") + " руб.";
            }
            labelTextResultPriceCar.Text = textTotalPrise;
        }
    }
}
