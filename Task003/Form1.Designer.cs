namespace Task003
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTextRate = new System.Windows.Forms.Label();
            this.labelTextPrice = new System.Windows.Forms.Label();
            this.textBoxInputRate = new System.Windows.Forms.TextBox();
            this.textBoxInputAmount = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTextResultMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTextRate
            // 
            this.labelTextRate.AutoSize = true;
            this.labelTextRate.Location = new System.Drawing.Point(30, 16);
            this.labelTextRate.Name = "labelTextRate";
            this.labelTextRate.Size = new System.Drawing.Size(33, 14);
            this.labelTextRate.TabIndex = 0;
            this.labelTextRate.Text = "Курс";
            // 
            // labelTextPrice
            // 
            this.labelTextPrice.AutoSize = true;
            this.labelTextPrice.Location = new System.Drawing.Point(10, 45);
            this.labelTextPrice.Name = "labelTextPrice";
            this.labelTextPrice.Size = new System.Drawing.Size(56, 14);
            this.labelTextPrice.TabIndex = 1;
            this.labelTextPrice.Text = "Цена ($)";
            // 
            // textBoxInputRate
            // 
            this.textBoxInputRate.Location = new System.Drawing.Point(74, 13);
            this.textBoxInputRate.Name = "textBoxInputRate";
            this.textBoxInputRate.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputRate.TabIndex = 2;
            this.textBoxInputRate.TextChanged += new System.EventHandler(this.textBoxInputRate_TextChanged);
            this.textBoxInputRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputRate_KeyPress);
            // 
            // textBoxInputAmount
            // 
            this.textBoxInputAmount.Location = new System.Drawing.Point(74, 42);
            this.textBoxInputAmount.Name = "textBoxInputAmount";
            this.textBoxInputAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputAmount.TabIndex = 3;
            this.textBoxInputAmount.TextChanged += new System.EventHandler(this.textBoxInputRate_TextChanged);
            this.textBoxInputAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputRate_KeyPress);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(180, 13);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 22);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTextResultMoney
            // 
            this.labelTextResultMoney.AutoSize = true;
            this.labelTextResultMoney.Location = new System.Drawing.Point(181, 45);
            this.labelTextResultMoney.Name = "labelTextResultMoney";
            this.labelTextResultMoney.Size = new System.Drawing.Size(0, 14);
            this.labelTextResultMoney.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 173);
            this.Controls.Add(this.labelTextResultMoney);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxInputAmount);
            this.Controls.Add(this.textBoxInputRate);
            this.Controls.Add(this.labelTextPrice);
            this.Controls.Add(this.labelTextRate);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextRate;
        private System.Windows.Forms.Label labelTextPrice;
        private System.Windows.Forms.TextBox textBoxInputRate;
        private System.Windows.Forms.TextBox textBoxInputAmount;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTextResultMoney;
    }
}

