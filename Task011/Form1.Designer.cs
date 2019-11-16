namespace Task011
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
            this.components = new System.ComponentModel.Container();
            this.labelResultStopwacht = new System.Windows.Forms.Label();
            this.labelTextInterval = new System.Windows.Forms.Label();
            this.labelTextMinutes = new System.Windows.Forms.Label();
            this.labelTextSeconds = new System.Windows.Forms.Label();
            this.numericUpDownInputMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInputSeconds = new System.Windows.Forms.NumericUpDown();
            this.buttonStartStopwacht = new System.Windows.Forms.Button();
            this.timerStopwacht = new System.Windows.Forms.Timer(this.components);
            this.groupBoxOutputResult = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputSeconds)).BeginInit();
            this.groupBoxOutputResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResultStopwacht
            // 
            this.labelResultStopwacht.AutoSize = true;
            this.labelResultStopwacht.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultStopwacht.Location = new System.Drawing.Point(20, 10);
            this.labelResultStopwacht.Name = "labelResultStopwacht";
            this.labelResultStopwacht.Size = new System.Drawing.Size(56, 23);
            this.labelResultStopwacht.TabIndex = 0;
            this.labelResultStopwacht.Text = "00 00";
            // 
            // labelTextInterval
            // 
            this.labelTextInterval.AutoSize = true;
            this.labelTextInterval.Location = new System.Drawing.Point(25, 50);
            this.labelTextInterval.Name = "labelTextInterval";
            this.labelTextInterval.Size = new System.Drawing.Size(61, 14);
            this.labelTextInterval.TabIndex = 1;
            this.labelTextInterval.Text = "Интервал";
            // 
            // labelTextMinutes
            // 
            this.labelTextMinutes.AutoSize = true;
            this.labelTextMinutes.Location = new System.Drawing.Point(25, 75);
            this.labelTextMinutes.Name = "labelTextMinutes";
            this.labelTextMinutes.Size = new System.Drawing.Size(50, 14);
            this.labelTextMinutes.TabIndex = 2;
            this.labelTextMinutes.Text = "Минуты";
            // 
            // labelTextSeconds
            // 
            this.labelTextSeconds.AutoSize = true;
            this.labelTextSeconds.Location = new System.Drawing.Point(150, 75);
            this.labelTextSeconds.Name = "labelTextSeconds";
            this.labelTextSeconds.Size = new System.Drawing.Size(55, 14);
            this.labelTextSeconds.TabIndex = 3;
            this.labelTextSeconds.Text = "Секунды";
            // 
            // numericUpDownInputMinutes
            // 
            this.numericUpDownInputMinutes.Location = new System.Drawing.Point(80, 73);
            this.numericUpDownInputMinutes.Name = "numericUpDownInputMinutes";
            this.numericUpDownInputMinutes.Size = new System.Drawing.Size(38, 22);
            this.numericUpDownInputMinutes.TabIndex = 4;
            this.numericUpDownInputMinutes.ValueChanged += new System.EventHandler(this.numericUpDownInput_ValueChanged);
            // 
            // numericUpDownInputSeconds
            // 
            this.numericUpDownInputSeconds.Location = new System.Drawing.Point(210, 73);
            this.numericUpDownInputSeconds.Name = "numericUpDownInputSeconds";
            this.numericUpDownInputSeconds.Size = new System.Drawing.Size(41, 22);
            this.numericUpDownInputSeconds.TabIndex = 5;
            this.numericUpDownInputSeconds.ValueChanged += new System.EventHandler(this.numericUpDownInput_ValueChanged);
            // 
            // buttonStartStopwacht
            // 
            this.buttonStartStopwacht.Location = new System.Drawing.Point(100, 125);
            this.buttonStartStopwacht.Name = "buttonStartStopwacht";
            this.buttonStartStopwacht.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStopwacht.TabIndex = 6;
            this.buttonStartStopwacht.Text = "Пуск";
            this.buttonStartStopwacht.UseVisualStyleBackColor = true;
            this.buttonStartStopwacht.Click += new System.EventHandler(this.buttonStartStopwacht_Click);
            // 
            // timerStopwacht
            // 
            this.timerStopwacht.Tick += new System.EventHandler(this.timerStopwacht_Tick);
            // 
            // groupBoxOutputResult
            // 
            this.groupBoxOutputResult.Controls.Add(this.labelResultStopwacht);
            this.groupBoxOutputResult.Location = new System.Drawing.Point(90, 10);
            this.groupBoxOutputResult.Name = "groupBoxOutputResult";
            this.groupBoxOutputResult.Size = new System.Drawing.Size(100, 40);
            this.groupBoxOutputResult.TabIndex = 7;
            this.groupBoxOutputResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.groupBoxOutputResult);
            this.Controls.Add(this.buttonStartStopwacht);
            this.Controls.Add(this.numericUpDownInputSeconds);
            this.Controls.Add(this.numericUpDownInputMinutes);
            this.Controls.Add(this.labelTextSeconds);
            this.Controls.Add(this.labelTextMinutes);
            this.Controls.Add(this.labelTextInterval);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputSeconds)).EndInit();
            this.groupBoxOutputResult.ResumeLayout(false);
            this.groupBoxOutputResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelResultStopwacht;
        private System.Windows.Forms.Label labelTextInterval;
        private System.Windows.Forms.Label labelTextMinutes;
        private System.Windows.Forms.Label labelTextSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownInputMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownInputSeconds;
        private System.Windows.Forms.Button buttonStartStopwacht;
        private System.Windows.Forms.Timer timerStopwacht;
        private System.Windows.Forms.GroupBox groupBoxOutputResult;
    }
}

