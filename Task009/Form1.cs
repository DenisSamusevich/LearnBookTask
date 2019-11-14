using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task009
{
    public partial class Form1 : Form
    {
        List<string> pictureList = new List<string>();
        int numberPicture = 0;

        int pictureBoxWidth;
        int pictureBoxHeight;
        int pictureBoxCoordinateX;
        int pictureBoxCoordinateY;
        string folderPath;
        public Form1()
        {
            InitializeComponent();

            pictureBoxHeight = pictureBoxViewPictures.Height;
            pictureBoxWidth = pictureBoxViewPictures.Width;
            pictureBoxCoordinateX = pictureBoxViewPictures.Location.X;
            pictureBoxCoordinateY = pictureBoxViewPictures.Location.Y;

            DirectoryInfo directoryInfoMyPictures = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            folderPath = directoryInfoMyPictures.FullName;

            FillListBox(folderPath);
        }

        private bool FillListBox(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles("*.jpg");
            pictureList.Clear();
            foreach (FileInfo fileInfo in fileInfos)
            {
                pictureList.Add(fileInfo.Name);
            }
            if (fileInfos.Length == 0)
            {
                return false;
            }
            else
            {
                numberPicture = 0;
                ShowPicture(path + "\\" + pictureList[numberPicture]);
                buttonPreviosPicture.Enabled = false;
                if (pictureList.Count == 1)
                {
                    buttonNextPicture.Enabled = false;
                }
                this.Text = folderPath;
                return true;
            }
        }
        private void ShowPicture (string picturePath)
        {
            double scaleWidth;
            double scaleHeight;

            pictureBoxViewPictures.Visible = false;
            pictureBoxViewPictures.Left = pictureBoxCoordinateX;
            pictureBoxViewPictures.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxViewPictures.Image = new Bitmap(picturePath);
            
            if ((pictureBoxViewPictures.Image.Width > pictureBoxWidth) || (pictureBoxViewPictures.Image.Height > pictureBoxHeight))
            {
                pictureBoxViewPictures.SizeMode = PictureBoxSizeMode.StretchImage;
                scaleWidth = (double)pictureBoxWidth / (double)pictureBoxViewPictures.Image.Height;
                scaleHeight = (double)pictureBoxWidth / (double)pictureBoxViewPictures.Image.Height;
                if (scaleHeight < scaleWidth)
                {
                    pictureBoxViewPictures.Width = Convert.ToInt16(pictureBoxViewPictures.Image.Width * scaleHeight);
                    pictureBoxViewPictures.Height = pictureBoxHeight;
                }
                else
                {
                    pictureBoxViewPictures.Width = pictureBoxWidth;
                    pictureBoxViewPictures.Height = Convert.ToInt16(pictureBoxViewPictures.Image.Height * scaleWidth); ;
                }
            }
            pictureBoxViewPictures.Left = pictureBoxCoordinateX + (pictureBoxWidth - pictureBoxViewPictures.Width) / 2;
            pictureBoxViewPictures.Top = pictureBoxCoordinateY + (pictureBoxHeight - pictureBoxViewPictures.Height) / 2;
            pictureBoxViewPictures.Visible = true;
        }

        private void buttonPreviosPicture_Click(object sender, EventArgs e)
        {
            if (!buttonNextPicture.Enabled)
            {
                buttonNextPicture.Enabled = true;
            }
            if (numberPicture > 0)
            {
                numberPicture--;
                ShowPicture(folderPath + "\\" + pictureList[numberPicture]);
                if (numberPicture == 0)
                {
                    buttonPreviosPicture.Enabled = false;
                }
            }
        }

        private void buttonNextPicture_Click(object sender, EventArgs e)
        {
            if (!buttonPreviosPicture.Enabled)
            {
                buttonPreviosPicture.Enabled = true;
            }
            if (numberPicture > 0)
            {
                numberPicture++;
                ShowPicture(folderPath + "\\" + pictureList[numberPicture]);
                if (numberPicture == 0)
                {
                    buttonNextPicture.Enabled = false;
                }
            }
        }

        private void buttonBrowseFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку, \n" + "в которой находятся иллюстрации";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.SelectedPath = folderPath;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                if (!FillListBox(folderPath))
                {
                    pictureBoxViewPictures.Image = null;
                }
            }
        }
    }
}
