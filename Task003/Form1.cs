using System;
using System.Windows.Forms;

namespace Task003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonOK.Enabled = false;
        }

        private void textBoxInputRate_KeyPress(object sender, KeyPressEventArgs e)
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
                if (sender.Equals(textBoxInputRate))
                {
                    if (textBoxInputRate.Text.IndexOf(',') != -1 || textBoxInputRate.Text.Length == 0)
                    {
                        e.Handled = true;
                    }
                }
                else if (sender.Equals(textBoxInputAmount))
                {
                    if (textBoxInputAmount.Text.IndexOf(',') != -1 || textBoxInputAmount.Text.Length == 0)
                    {
                        e.Handled = true;
                    }
                }
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBoxInputRate))
                    {
                        textBoxInputAmount.Focus();
                    }
                    else
                    {
                        buttonOK.Focus();
                    }
                }
                return;
            }
            e.Handled = true;
        }

        private void textBoxInputRate_TextChanged(object sender, EventArgs e)
        {
            labelTextResultMoney.Text = "";
            if (textBoxInputRate.Text.Length == 0 || textBoxInputAmount.Text.Length == 0)
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
            double rateUsdToRub;
            double usd;
            double rub;
            try
            {
                try
                {
                    rateUsdToRub = Convert.ToDouble(textBoxInputRate.Text);
                }
                catch
                {
                    throw new System.FormatException("textBoxInputRate");
                }
                try
                {
                    usd = Convert.ToDouble(textBoxInputAmount.Text);
                }
                catch
                {
                    throw new System.FormatException("textBoxInputAmount");
                }
                rub = usd * rateUsdToRub;
                labelTextResultMoney.Text = rub.ToString("N")+" руб";
            }
            catch (Exception exc)
            {
                if (exc.Message.Equals("textBoxInputRate", StringComparison.OrdinalIgnoreCase))
                {
                    textBoxInputRate.Focus();
                }
                else if (exc.Message.Equals("textBoxInputAmount",StringComparison.OrdinalIgnoreCase))
                {
                    textBoxInputAmount.Focus();
                }
            }
        }
    }
}
