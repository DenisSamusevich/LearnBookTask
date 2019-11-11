using System;
using System.Windows.Forms;

namespace Task004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButtonSize9x12.Checked = true;
            buttonOK.Enabled = false;
        }

        private void textBoxInputAmountFoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
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

        private void radioButtonSize_Click(object sender, EventArgs e)
        {
            labelTextResultPrice.Text = string.Empty;
            textBoxInputAmountFoto.Focus();
        }

        private void textBoxInputAmountFoto_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInputAmountFoto.Text.Length == 0)
            {
                buttonOK.Enabled = false;
            }
            else
            {
                buttonOK.Enabled = true;
            }
            labelTextResultPrice.Text = string.Empty;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double priceOneFoto = 0;
            int amountFoto;
            double priceOrder;

            if (radioButtonSize9x12.Checked)
            {
                priceOneFoto = 8.50;
            }
            else if (radioButtonSize12x15.Checked)
            {
                priceOneFoto = 10;
            }
            else if (radioButtonSize18x24.Checked)
            {
                priceOneFoto = 15.5;
            }

            try
            {
                amountFoto = Convert.ToInt32(textBoxInputAmountFoto.Text);
                priceOrder = priceOneFoto * amountFoto;
                labelTextResultPrice.Text = "Цена: " + priceOneFoto.ToString() + " руб./шт" +
                    "\nКоличество: " + amountFoto.ToString() + " шт.\n" +
                    "Сумма заказа: " + priceOrder.ToString("N") + " руб.";
            }
            catch
            {
                textBoxInputAmountFoto.Focus();
            }
        }
    }
}
