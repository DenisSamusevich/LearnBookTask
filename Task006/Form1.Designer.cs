namespace Task006
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
            this.labelTextWidhtCm = new System.Windows.Forms.Label();
            this.labelTextHeightCm = new System.Windows.Forms.Label();
            this.labelTextMaterial = new System.Windows.Forms.Label();
            this.textBoxInputWidthCm = new System.Windows.Forms.TextBox();
            this.textBoxInputHeigthCm = new System.Windows.Forms.TextBox();
            this.labelOutputResult = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.comboBoxChoiceMaterial = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTextWidhtCm
            // 
            this.labelTextWidhtCm.AutoSize = true;
            this.labelTextWidhtCm.Location = new System.Drawing.Point(15, 20);
            this.labelTextWidhtCm.Name = "labelTextWidhtCm";
            this.labelTextWidhtCm.Size = new System.Drawing.Size(83, 14);
            this.labelTextWidhtCm.TabIndex = 0;
            this.labelTextWidhtCm.Text = "Ширина (см.)";
            // 
            // labelTextHeightCm
            // 
            this.labelTextHeightCm.AutoSize = true;
            this.labelTextHeightCm.Location = new System.Drawing.Point(15, 48);
            this.labelTextHeightCm.Name = "labelTextHeightCm";
            this.labelTextHeightCm.Size = new System.Drawing.Size(79, 14);
            this.labelTextHeightCm.TabIndex = 1;
            this.labelTextHeightCm.Text = "Высота (см.)";
            // 
            // labelTextMaterial
            // 
            this.labelTextMaterial.AutoSize = true;
            this.labelTextMaterial.Location = new System.Drawing.Point(15, 80);
            this.labelTextMaterial.Name = "labelTextMaterial";
            this.labelTextMaterial.Size = new System.Drawing.Size(66, 14);
            this.labelTextMaterial.TabIndex = 2;
            this.labelTextMaterial.Text = "Материал:";
            // 
            // textBoxInputWidthCm
            // 
            this.textBoxInputWidthCm.Location = new System.Drawing.Point(120, 18);
            this.textBoxInputWidthCm.Name = "textBoxInputWidthCm";
            this.textBoxInputWidthCm.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputWidthCm.TabIndex = 3;
            this.textBoxInputWidthCm.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInputWidthCm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // textBoxInputHeigthCm
            // 
            this.textBoxInputHeigthCm.Location = new System.Drawing.Point(120, 45);
            this.textBoxInputHeigthCm.Name = "textBoxInputHeigthCm";
            this.textBoxInputHeigthCm.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputHeigthCm.TabIndex = 4;
            this.textBoxInputHeigthCm.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInputHeigthCm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // labelOutputResult
            // 
            this.labelOutputResult.AutoSize = true;
            this.labelOutputResult.Location = new System.Drawing.Point(15, 150);
            this.labelOutputResult.Name = "labelOutputResult";
            this.labelOutputResult.Size = new System.Drawing.Size(0, 14);
            this.labelOutputResult.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(15, 120);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // comboBoxChoiceMaterial
            // 
            this.comboBoxChoiceMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceMaterial.FormattingEnabled = true;
            this.comboBoxChoiceMaterial.Items.AddRange(new object[] {
            "пластик",
            "алюмиий",
            "бамбук",
            "соломка",
            "текстиль"});
            this.comboBoxChoiceMaterial.Location = new System.Drawing.Point(120, 76);
            this.comboBoxChoiceMaterial.Name = "comboBoxChoiceMaterial";
            this.comboBoxChoiceMaterial.Size = new System.Drawing.Size(121, 22);
            this.comboBoxChoiceMaterial.TabIndex = 7;
            this.comboBoxChoiceMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiceMaterial_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.comboBoxChoiceMaterial);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelOutputResult);
            this.Controls.Add(this.textBoxInputHeigthCm);
            this.Controls.Add(this.textBoxInputWidthCm);
            this.Controls.Add(this.labelTextMaterial);
            this.Controls.Add(this.labelTextHeightCm);
            this.Controls.Add(this.labelTextWidhtCm);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жалюзи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextWidhtCm;
        private System.Windows.Forms.Label labelTextHeightCm;
        private System.Windows.Forms.Label labelTextMaterial;
        private System.Windows.Forms.TextBox textBoxInputWidthCm;
        private System.Windows.Forms.TextBox textBoxInputHeigthCm;
        private System.Windows.Forms.Label labelOutputResult;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox comboBoxChoiceMaterial;
    }
}

