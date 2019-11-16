namespace Task010
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
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelResultMinutes = new System.Windows.Forms.Label();
            this.labelResultSeconds = new System.Windows.Forms.Label();
            this.labelTextColon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(40, 120);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Пуск";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(160, 120);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelResultMinutes
            // 
            this.labelResultMinutes.AutoSize = true;
            this.labelResultMinutes.Location = new System.Drawing.Point(100, 15);
            this.labelResultMinutes.Name = "labelResultMinutes";
            this.labelResultMinutes.Size = new System.Drawing.Size(21, 14);
            this.labelResultMinutes.TabIndex = 2;
            this.labelResultMinutes.Text = "00";
            // 
            // labelResultSeconds
            // 
            this.labelResultSeconds.AutoSize = true;
            this.labelResultSeconds.Location = new System.Drawing.Point(130, 15);
            this.labelResultSeconds.Name = "labelResultSeconds";
            this.labelResultSeconds.Size = new System.Drawing.Size(21, 14);
            this.labelResultSeconds.TabIndex = 3;
            this.labelResultSeconds.Text = "00";
            // 
            // labelTextColon
            // 
            this.labelTextColon.AutoSize = true;
            this.labelTextColon.Location = new System.Drawing.Point(120, 15);
            this.labelTextColon.Name = "labelTextColon";
            this.labelTextColon.Size = new System.Drawing.Size(11, 14);
            this.labelTextColon.TabIndex = 4;
            this.labelTextColon.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.labelTextColon);
            this.Controls.Add(this.labelResultSeconds);
            this.Controls.Add(this.labelResultMinutes);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Секундомер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerStopwatch;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelResultMinutes;
        private System.Windows.Forms.Label labelResultSeconds;
        private System.Windows.Forms.Label labelTextColon;
    }
}

