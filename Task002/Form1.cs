using System;
using System.Windows.Forms;

namespace Task002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonOK.Enabled = false;
        }

        private void textBoxInputNumberPounds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBoxInputNumberPounds.Text.IndexOf(',') != -1 || textBoxInputNumberPounds.Text.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    buttonOK.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBoxInputNumberPounds_TextChanged(object sender, EventArgs e)
        {
            labelTextResultKilogram.Text = "";
            if (textBoxInputNumberPounds.Text.Length == 0)
            {
                buttonOK.Enabled = false;
            }
            else
            {
                buttonOK.Enabled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double pounds;
            double kg;
            try
            {
                pounds = Math.Round(Convert.ToDouble(textBoxInputNumberPounds.Text), 3);
                kg = Math.Round(pounds * 0.453592, 3);
                labelTextResultKilogram.Text = pounds.ToString() + " ф. = " + kg.ToString() + " кг";
            }
            catch (Exception)
            {
                textBoxInputNumberPounds.Focus();
            }
        }

    }
}
