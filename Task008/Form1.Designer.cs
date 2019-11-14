namespace Task008
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
            this.listBoxViewPictures = new System.Windows.Forms.ListBox();
            this.buttonBrowseFolders = new System.Windows.Forms.Button();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.pictureBoxViewPictures = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxViewPictures
            // 
            this.listBoxViewPictures.FormattingEnabled = true;
            this.listBoxViewPictures.ItemHeight = 14;
            this.listBoxViewPictures.Location = new System.Drawing.Point(13, 48);
            this.listBoxViewPictures.Name = "listBoxViewPictures";
            this.listBoxViewPictures.Size = new System.Drawing.Size(120, 200);
            this.listBoxViewPictures.TabIndex = 0;
            this.listBoxViewPictures.SelectedIndexChanged += new System.EventHandler(this.listBoxViewPictures_SelectedIndexChanged);
            // 
            // buttonBrowseFolders
            // 
            this.buttonBrowseFolders.Location = new System.Drawing.Point(13, 300);
            this.buttonBrowseFolders.Name = "buttonBrowseFolders";
            this.buttonBrowseFolders.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFolders.TabIndex = 1;
            this.buttonBrowseFolders.Text = "Browse";
            this.buttonBrowseFolders.UseVisualStyleBackColor = true;
            this.buttonBrowseFolders.Click += new System.EventHandler(this.buttonBrowseFolders_Click);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(13, 13);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(38, 14);
            this.labelFolderPath.TabIndex = 2;
            this.labelFolderPath.Text = "label1";
            // 
            // pictureBoxViewPictures
            // 
            this.pictureBoxViewPictures.Location = new System.Drawing.Point(140, 48);
            this.pictureBoxViewPictures.Name = "pictureBoxViewPictures";
            this.pictureBoxViewPictures.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxViewPictures.TabIndex = 3;
            this.pictureBoxViewPictures.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.pictureBoxViewPictures);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.buttonBrowseFolders);
            this.Controls.Add(this.listBoxViewPictures);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр иллюстраций";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxViewPictures;
        private System.Windows.Forms.Button buttonBrowseFolders;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.PictureBox pictureBoxViewPictures;
    }
}

