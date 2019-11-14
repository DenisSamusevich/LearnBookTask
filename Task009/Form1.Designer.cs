namespace Task009
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
            this.pictureBoxViewPictures = new System.Windows.Forms.PictureBox();
            this.buttonBrowseFolders = new System.Windows.Forms.Button();
            this.buttonPreviosPicture = new System.Windows.Forms.Button();
            this.buttonNextPicture = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxViewPictures
            // 
            this.pictureBoxViewPictures.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxViewPictures.Name = "pictureBoxViewPictures";
            this.pictureBoxViewPictures.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxViewPictures.TabIndex = 0;
            this.pictureBoxViewPictures.TabStop = false;
            // 
            // buttonBrowseFolders
            // 
            this.buttonBrowseFolders.Location = new System.Drawing.Point(13, 376);
            this.buttonBrowseFolders.Name = "buttonBrowseFolders";
            this.buttonBrowseFolders.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFolders.TabIndex = 1;
            this.buttonBrowseFolders.Text = "Обзор";
            this.toolTip1.SetToolTip(this.buttonBrowseFolders, "Выбор папки");
            this.buttonBrowseFolders.UseVisualStyleBackColor = true;
            this.buttonBrowseFolders.Click += new System.EventHandler(this.buttonBrowseFolders_Click);
            // 
            // buttonPreviosPicture
            // 
            this.buttonPreviosPicture.Location = new System.Drawing.Point(292, 376);
            this.buttonPreviosPicture.Name = "buttonPreviosPicture";
            this.buttonPreviosPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviosPicture.TabIndex = 2;
            this.buttonPreviosPicture.Text = "<";
            this.toolTip1.SetToolTip(this.buttonPreviosPicture, "Назад");
            this.buttonPreviosPicture.UseVisualStyleBackColor = true;
            this.buttonPreviosPicture.Click += new System.EventHandler(this.buttonPreviosPicture_Click);
            // 
            // buttonNextPicture
            // 
            this.buttonNextPicture.Location = new System.Drawing.Point(373, 376);
            this.buttonNextPicture.Name = "buttonNextPicture";
            this.buttonNextPicture.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPicture.TabIndex = 3;
            this.buttonNextPicture.Text = ">";
            this.toolTip1.SetToolTip(this.buttonNextPicture, "Далее");
            this.buttonNextPicture.UseVisualStyleBackColor = true;
            this.buttonNextPicture.Click += new System.EventHandler(this.buttonNextPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.buttonNextPicture);
            this.Controls.Add(this.buttonPreviosPicture);
            this.Controls.Add(this.buttonBrowseFolders);
            this.Controls.Add(this.pictureBoxViewPictures);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр иллюстраций";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewPictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxViewPictures;
        private System.Windows.Forms.Button buttonBrowseFolders;
        private System.Windows.Forms.Button buttonPreviosPicture;
        private System.Windows.Forms.Button buttonNextPicture;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

