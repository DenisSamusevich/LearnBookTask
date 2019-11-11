namespace Task005
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
            this.labelTextCarModel = new System.Windows.Forms.Label();
            this.labelTextStartPrice = new System.Windows.Forms.Label();
            this.checkBoxABS = new System.Windows.Forms.CheckBox();
            this.checkBoxFogLights = new System.Windows.Forms.CheckBox();
            this.checkBoxParkingSensors = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTextResultPriceCar = new System.Windows.Forms.Label();
            this.pictureBoxImageCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextCarModel
            // 
            this.labelTextCarModel.AutoSize = true;
            this.labelTextCarModel.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelTextCarModel.Location = new System.Drawing.Point(13, 13);
            this.labelTextCarModel.Name = "labelTextCarModel";
            this.labelTextCarModel.Size = new System.Drawing.Size(158, 33);
            this.labelTextCarModel.TabIndex = 0;
            this.labelTextCarModel.Text = "Skoda Fabia";
            // 
            // labelTextStartPrice
            // 
            this.labelTextStartPrice.AutoSize = true;
            this.labelTextStartPrice.Location = new System.Drawing.Point(13, 50);
            this.labelTextStartPrice.Name = "labelTextStartPrice";
            this.labelTextStartPrice.Size = new System.Drawing.Size(157, 14);
            this.labelTextStartPrice.TabIndex = 1;
            this.labelTextStartPrice.Text = "Базовая цена: 39 000 руб.";
            // 
            // checkBoxABS
            // 
            this.checkBoxABS.AutoSize = true;
            this.checkBoxABS.Location = new System.Drawing.Point(25, 80);
            this.checkBoxABS.Name = "checkBoxABS";
            this.checkBoxABS.Size = new System.Drawing.Size(48, 18);
            this.checkBoxABS.TabIndex = 2;
            this.checkBoxABS.Text = "ABS";
            this.checkBoxABS.UseVisualStyleBackColor = true;
            this.checkBoxABS.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxFogLights
            // 
            this.checkBoxFogLights.AutoSize = true;
            this.checkBoxFogLights.Location = new System.Drawing.Point(25, 100);
            this.checkBoxFogLights.Name = "checkBoxFogLights";
            this.checkBoxFogLights.Size = new System.Drawing.Size(164, 18);
            this.checkBoxFogLights.TabIndex = 3;
            this.checkBoxFogLights.Text = "Противотуманные фары";
            this.checkBoxFogLights.UseVisualStyleBackColor = true;
            this.checkBoxFogLights.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxParkingSensors
            // 
            this.checkBoxParkingSensors.AutoSize = true;
            this.checkBoxParkingSensors.Location = new System.Drawing.Point(25, 120);
            this.checkBoxParkingSensors.Name = "checkBoxParkingSensors";
            this.checkBoxParkingSensors.Size = new System.Drawing.Size(93, 18);
            this.checkBoxParkingSensors.TabIndex = 4;
            this.checkBoxParkingSensors.Text = "Парктроник";
            this.checkBoxParkingSensors.UseVisualStyleBackColor = true;
            this.checkBoxParkingSensors.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(25, 160);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTextResultPriceCar
            // 
            this.labelTextResultPriceCar.AutoSize = true;
            this.labelTextResultPriceCar.Location = new System.Drawing.Point(100, 212);
            this.labelTextResultPriceCar.Name = "labelTextResultPriceCar";
            this.labelTextResultPriceCar.Size = new System.Drawing.Size(0, 14);
            this.labelTextResultPriceCar.TabIndex = 6;
            // 
            // pictureBoxImageCar
            // 
            this.pictureBoxImageCar.Image = global::Task005.Properties.Resources.ScodaFabia;
            this.pictureBoxImageCar.Location = new System.Drawing.Point(210, 13);
            this.pictureBoxImageCar.Name = "pictureBoxImageCar";
            this.pictureBoxImageCar.Size = new System.Drawing.Size(259, 195);
            this.pictureBoxImageCar.TabIndex = 7;
            this.pictureBoxImageCar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pictureBoxImageCar);
            this.Controls.Add(this.labelTextResultPriceCar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxParkingSensors);
            this.Controls.Add(this.checkBoxFogLights);
            this.Controls.Add(this.checkBoxABS);
            this.Controls.Add(this.labelTextStartPrice);
            this.Controls.Add(this.labelTextCarModel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплектация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextCarModel;
        private System.Windows.Forms.Label labelTextStartPrice;
        private System.Windows.Forms.CheckBox checkBoxABS;
        private System.Windows.Forms.CheckBox checkBoxFogLights;
        private System.Windows.Forms.CheckBox checkBoxParkingSensors;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTextResultPriceCar;
        private System.Windows.Forms.PictureBox pictureBoxImageCar;
    }
}

