namespace Task001
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTextMiles = new System.Windows.Forms.Label();
            this.textBoxInputNumberMiles = new System.Windows.Forms.TextBox();
            this.labelTextResultKm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(150, 25);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 22);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTextMiles
            // 
            this.labelTextMiles.AutoSize = true;
            this.labelTextMiles.Location = new System.Drawing.Point(15, 28);
            this.labelTextMiles.Name = "labelTextMiles";
            this.labelTextMiles.Size = new System.Drawing.Size(41, 14);
            this.labelTextMiles.TabIndex = 1;
            this.labelTextMiles.Text = "Мили:";
            // 
            // textBoxInputNumberMiles
            // 
            this.textBoxInputNumberMiles.Location = new System.Drawing.Point(60, 25);
            this.textBoxInputNumberMiles.Name = "textBoxInputNumberMiles";
            this.textBoxInputNumberMiles.Size = new System.Drawing.Size(80, 22);
            this.textBoxInputNumberMiles.TabIndex = 2;
            this.textBoxInputNumberMiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputNumberMiles_KeyPress);
            // 
            // labelTextResultKm
            // 
            this.labelTextResultKm.AutoSize = true;
            this.labelTextResultKm.Location = new System.Drawing.Point(60, 50);
            this.labelTextResultKm.Name = "labelTextResultKm";
            this.labelTextResultKm.Size = new System.Drawing.Size(0, 14);
            this.labelTextResultKm.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.labelTextResultKm);
            this.Controls.Add(this.textBoxInputNumberMiles);
            this.Controls.Add(this.labelTextMiles);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевод Мили-Километры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTextMiles;
        private System.Windows.Forms.TextBox textBoxInputNumberMiles;
        private System.Windows.Forms.Label labelTextResultKm;
    }
}

