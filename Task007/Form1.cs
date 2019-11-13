using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task007
{
    public partial class Form1 : Form
    {
        private const int buttonWidth = 40;
        private const int buttonHeight = 22;
        private const int distanceX = 5;
        private const int distanceY = 5;

        private Button[] buttonsCalculator = new Button[15];
        private char[] buttonsText = {'7','8','9','+',
                                      '4','5','6','-',
                                      '1','2','3','=',
                                      '0',',','C'};
        private int[] buttonTag = { 7, 8, 9, -3, 
                                    4, 5, 6, -4, 
                                    1, 2, 3, -2, 
                                    0, -1, -5 };
        private double result = 0;
        private int operationCode = 0;
        private bool firstNumber = true;
        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(4 * buttonWidth + 5 * distanceX, 5 * buttonHeight + 7 * distanceY);

            labelOutputResult.SetBounds(distanceX, distanceY, 4 * buttonWidth + 3 * distanceX, buttonHeight);
            labelOutputResult.Text = "0";

            int numberButton = 0;
            int coordinatesButtonX;

            
            int coordinatesButtonY = labelOutputResult.Bottom + distanceY;

            for (int i = 0; i < 4; i++)
            {
                coordinatesButtonX = distanceX;
                for (int j = 0; j < 4; j++)
                {
                    if (!((i == 3) && (j == 0)))
                    {
                        buttonsCalculator[numberButton] = new Button();
                        buttonsCalculator[numberButton].SetBounds(coordinatesButtonX, coordinatesButtonY, buttonWidth, buttonHeight);
                        buttonsCalculator[numberButton].Tag = buttonTag[numberButton];
                        buttonsCalculator[numberButton].Text = buttonsText[numberButton].ToString();

                        this.buttonsCalculator[numberButton].Click += new EventHandler(this.Button_Click);

                        if (buttonTag[numberButton] < 0)
                        {
                            buttonsCalculator[numberButton].BackColor = SystemColors.ControlLight;
                        }
                        this.Controls.Add(this.buttonsCalculator[numberButton]);
                        coordinatesButtonX = coordinatesButtonX + buttonWidth + distanceX;
                        numberButton++;
                    }
                    else
                    {
                        buttonsCalculator[numberButton] = new Button();
                        buttonsCalculator[numberButton].SetBounds(coordinatesButtonX, coordinatesButtonY, buttonWidth * 2 + distanceX, buttonHeight);
                        buttonsCalculator[numberButton].Tag = buttonTag[numberButton];
                        buttonsCalculator[numberButton].Text = buttonsText[numberButton].ToString();

                        this.buttonsCalculator[numberButton].Click += new EventHandler(this.Button_Click);

                        this.Controls.Add(this.buttonsCalculator[numberButton]);
                        coordinatesButtonX = coordinatesButtonX + 2 * buttonWidth + 2 * distanceX;
                        numberButton++;
                        j++;
                    }
                }
                coordinatesButtonY = coordinatesButtonY + buttonHeight + distanceY;
            }
        }
        private void Button_Click(object sender,EventArgs e)
        {
            Button pressedButton = (Button)sender;
            if (Convert.ToInt32(pressedButton.Tag) > 0)
            {
                if (firstNumber)
                {
                    labelOutputResult.Text = pressedButton.Text;
                    firstNumber = false;
                }
                else
                {
                    labelOutputResult.Text += pressedButton.Text;
                }
                return;
            }
            else if (Convert.ToInt32(pressedButton.Tag) == 0)
            {
                if (firstNumber)
                {
                    labelOutputResult.Text = pressedButton.Text;
                }
                else if (labelOutputResult.Text != "0")
                {
                    labelOutputResult.Text += pressedButton.Text;
                }
                return;
            }
            else if (Convert.ToInt32(pressedButton.Tag) == -1)
            {
                if (firstNumber)
                {
                    labelOutputResult.Text = "0,";
                    firstNumber = false;
                }
                else
                {
                    if (labelOutputResult.Text.IndexOf(",") == -1)
                    {
                        labelOutputResult.Text += pressedButton.Text;
                    }
                }
                return;
            }
            else if (Convert.ToInt32(pressedButton.Tag) == -5)
            {
                result = 0;
                operationCode = 0;
                labelOutputResult.Text = "0";
                firstNumber = true;
                return;
            }
            else if (Convert.ToInt32(pressedButton.Tag) < -1)
            {
                double indicatorNumber = Convert.ToDouble(labelOutputResult.Text);
                if(result!= 0)
                {
                    switch (operationCode)
                    {
                        case -3: result += indicatorNumber; break;
                        case -4: result -= indicatorNumber; break;
                        case -2: result = indicatorNumber; break;
                    }
                    labelOutputResult.Text = result.ToString("N");

                }
                else
                {
                    result = indicatorNumber;
                }
                operationCode = Convert.ToInt32(pressedButton.Tag);
                firstNumber = true;
            }
            
        }
    }
}
