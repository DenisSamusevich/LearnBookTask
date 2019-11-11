namespace Task004
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
            this.radioButtonSize9x12 = new System.Windows.Forms.RadioButton();
            this.radioButtonSize12x15 = new System.Windows.Forms.RadioButton();
            this.radioButtonSize18x24 = new System.Windows.Forms.RadioButton();
            this.labelTextSizeFoto = new System.Windows.Forms.Label();
            this.textBoxInputAmountFoto = new System.Windows.Forms.TextBox();
            this.labelTextAmountFoto = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTextResultPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonSize9x12
            // 
            this.radioButtonSize9x12.AutoSize = true;
            this.radioButtonSize9x12.Location = new System.Drawing.Point(13, 30);
            this.radioButtonSize9x12.Name = "radioButtonSize9x12";
            this.radioButtonSize9x12.Size = new System.Drawing.Size(52, 18);
            this.radioButtonSize9x12.TabIndex = 0;
            this.radioButtonSize9x12.TabStop = true;
            this.radioButtonSize9x12.Text = "9x12";
            this.radioButtonSize9x12.UseVisualStyleBackColor = true;
            this.radioButtonSize9x12.Click += new System.EventHandler(this.radioButtonSize_Click);
            // 
            // radioButtonSize12x15
            // 
            this.radioButtonSize12x15.AutoSize = true;
            this.radioButtonSize12x15.Location = new System.Drawing.Point(13, 50);
            this.radioButtonSize12x15.Name = "radioButtonSize12x15";
            this.radioButtonSize12x15.Size = new System.Drawing.Size(59, 18);
            this.radioButtonSize12x15.TabIndex = 1;
            this.radioButtonSize12x15.TabStop = true;
            this.radioButtonSize12x15.Text = "12x15";
            this.radioButtonSize12x15.UseVisualStyleBackColor = true;
            this.radioButtonSize12x15.Click += new System.EventHandler(this.radioButtonSize_Click);
            // 
            // radioButtonSize18x24
            // 
            this.radioButtonSize18x24.AutoSize = true;
            this.radioButtonSize18x24.Location = new System.Drawing.Point(12, 70);
            this.radioButtonSize18x24.Name = "radioButtonSize18x24";
            this.radioButtonSize18x24.Size = new System.Drawing.Size(59, 18);
            this.radioButtonSize18x24.TabIndex = 2;
            this.radioButtonSize18x24.TabStop = true;
            this.radioButtonSize18x24.Text = "18x24";
            this.radioButtonSize18x24.UseVisualStyleBackColor = true;
            this.radioButtonSize18x24.Click += new System.EventHandler(this.radioButtonSize_Click);
            // 
            // labelTextSizeFoto
            // 
            this.labelTextSizeFoto.AutoSize = true;
            this.labelTextSizeFoto.Location = new System.Drawing.Point(20, 10);
            this.labelTextSizeFoto.Name = "labelTextSizeFoto";
            this.labelTextSizeFoto.Size = new System.Drawing.Size(47, 14);
            this.labelTextSizeFoto.TabIndex = 3;
            this.labelTextSizeFoto.Text = "Pазмер";
            // 
            // textBoxInputAmountFoto
            // 
            this.textBoxInputAmountFoto.Location = new System.Drawing.Point(150, 30);
            this.textBoxInputAmountFoto.Name = "textBoxInputAmountFoto";
            this.textBoxInputAmountFoto.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputAmountFoto.TabIndex = 4;
            this.textBoxInputAmountFoto.TextChanged += new System.EventHandler(this.textBoxInputAmountFoto_TextChanged);
            this.textBoxInputAmountFoto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputAmountFoto_KeyPress);
            // 
            // labelTextAmountFoto
            // 
            this.labelTextAmountFoto.AutoSize = true;
            this.labelTextAmountFoto.Location = new System.Drawing.Point(150, 10);
            this.labelTextAmountFoto.Name = "labelTextAmountFoto";
            this.labelTextAmountFoto.Size = new System.Drawing.Size(74, 14);
            this.labelTextAmountFoto.TabIndex = 5;
            this.labelTextAmountFoto.Text = "Количество";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(150, 60);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTextResultPrice
            // 
            this.labelTextResultPrice.AutoSize = true;
            this.labelTextResultPrice.Location = new System.Drawing.Point(20, 110);
            this.labelTextResultPrice.Name = "labelTextResultPrice";
            this.labelTextResultPrice.Size = new System.Drawing.Size(0, 14);
            this.labelTextResultPrice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.labelTextResultPrice);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTextAmountFoto);
            this.Controls.Add(this.textBoxInputAmountFoto);
            this.Controls.Add(this.labelTextSizeFoto);
            this.Controls.Add(this.radioButtonSize18x24);
            this.Controls.Add(this.radioButtonSize12x15);
            this.Controls.Add(this.radioButtonSize9x12);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет стоимости фото";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSize9x12;
        private System.Windows.Forms.RadioButton radioButtonSize12x15;
        private System.Windows.Forms.RadioButton radioButtonSize18x24;
        private System.Windows.Forms.Label labelTextSizeFoto;
        private System.Windows.Forms.TextBox textBoxInputAmountFoto;
        private System.Windows.Forms.Label labelTextAmountFoto;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTextResultPrice;
    }
}

