using System;
using System.Windows.Forms;

namespace Task001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInputNumberMiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBoxInputNumberMiles.Text.IndexOf(',') != -1)
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double mile;
            double km;
            try
            {
                mile = Convert.ToDouble(textBoxInputNumberMiles.Text);
                km = mile * 1.60934;
                labelTextResultKm.Text = Math.Round(km, 2).ToString() + " км";
            }
            catch
            {
                textBoxInputNumberMiles.Focus();
            }

        }
    }
}
