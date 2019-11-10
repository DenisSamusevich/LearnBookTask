namespace Task002
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
            this.labelTextWeightInPounds = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxInputNumberPounds = new System.Windows.Forms.TextBox();
            this.labelTextResultKilogram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTextWeightInPounds
            // 
            this.labelTextWeightInPounds.AutoSize = true;
            this.labelTextWeightInPounds.Location = new System.Drawing.Point(40, 33);
            this.labelTextWeightInPounds.Name = "labelTextWeightInPounds";
            this.labelTextWeightInPounds.Size = new System.Drawing.Size(82, 14);
            this.labelTextWeightInPounds.TabIndex = 0;
            this.labelTextWeightInPounds.Text = "Вес в фунтах";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(240, 30);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxInputNumberPounds
            // 
            this.textBoxInputNumberPounds.Location = new System.Drawing.Point(130, 30);
            this.textBoxInputNumberPounds.Name = "textBoxInputNumberPounds";
            this.textBoxInputNumberPounds.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputNumberPounds.TabIndex = 2;
            this.textBoxInputNumberPounds.TextChanged += new System.EventHandler(this.textBoxInputNumberPounds_TextChanged);
            this.textBoxInputNumberPounds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputNumberPounds_KeyPress);
            // 
            // labelTextResultKilogram
            // 
            this.labelTextResultKilogram.AutoSize = true;
            this.labelTextResultKilogram.Location = new System.Drawing.Point(127, 66);
            this.labelTextResultKilogram.Name = "labelTextResultKilogram";
            this.labelTextResultKilogram.Size = new System.Drawing.Size(0, 14);
            this.labelTextResultKilogram.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 173);
            this.Controls.Add(this.labelTextResultKilogram);
            this.Controls.Add(this.textBoxInputNumberPounds);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTextWeightInPounds);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фунты-килограммы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextWeightInPounds;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxInputNumberPounds;
        private System.Windows.Forms.Label labelTextResultKilogram;
    }
}

