using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //comboBoxChoiceMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBoxChoiceMaterial.Items.Add("пластик");
            //comboBoxChoiceMaterial.Items.Add("алюминий");
            //comboBoxChoiceMaterial.Items.Add("бамбук");
            //comboBoxChoiceMaterial.Items.Add("соломка");
            //comboBoxChoiceMaterial.Items.Add("текстиль");
            comboBoxChoiceMaterial.SelectedIndex = 0;
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBoxInputWidthCm))
                    {
                        textBoxInputHeigthCm.Focus();
                    }
                    else
                    {
                        comboBoxChoiceMaterial.Focus();
                    }
                }
                return;
            }
            e.Handled = true;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textBoxInputWidthCm.Text.Length == 0||textBoxInputHeigthCm.Text.Length == 0)
            {
                buttonOK.Enabled = false;
            }
            else
            {
                buttonOK.Enabled = true;
            }
            labelOutputResult.Text = string.Empty;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double widthCm;
            double heightCm;
            int priceMaterial = 0;
            double totalPrice;

            try
            {
                try
                {
                    widthCm = Convert.ToDouble(textBoxInputWidthCm.Text);

                }
                catch
                {
                    throw new FormatException("textBoxInputWidthCm");
                }
                try
                {
                    heightCm = Convert.ToDouble(textBoxInputHeigthCm.Text);

                }
                catch
                {
                    throw new FormatException("textBoxInputHeigthCm");
                }
                switch ((Material)comboBoxChoiceMaterial.SelectedIndex)
                {
                    case Material.Plastic: priceMaterial = 50; break;
                    case Material.Aluminum: priceMaterial = 100; break;
                    case Material.Bamboo: priceMaterial = 75; break;
                    case Material.Straw: priceMaterial = 70; break;
                    case Material.Textile: priceMaterial = 60; break;
                }
                totalPrice = (widthCm * heightCm / 10000) * priceMaterial;
                labelOutputResult.Text = "Размер: " + widthCm + "x" + heightCm + " см." +
                    "\nЦена (руб./м.кв.): " + priceMaterial.ToString("N") + " руб." +
                    "\nСумма: " + totalPrice.ToString("N") + " руб.";
            }
            catch (Exception exc)
            {
                if (exc.Message.Equals("textBoxInputWidthCm", StringComparison.OrdinalIgnoreCase))
                {
                    textBoxInputWidthCm.Focus();
                }
                else if (exc.Message.Equals("textBoxInputHeigthCm", StringComparison.OrdinalIgnoreCase))
                {
                    textBoxInputHeigthCm.Focus();
                }
            }
        }

        private void comboBoxChoiceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutputResult.Text = string.Empty;
        }
    }
}
