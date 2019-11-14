using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task008
{
    public partial class Form1 : Form
    {
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

            listBoxViewPictures.Sorted = true;

            DirectoryInfo directoryInfoMyPictures = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            folderPath = directoryInfoMyPictures.FullName;
            labelFolderPath.Text = folderPath;

            FillListBox(folderPath);
        }

        private bool FillListBox(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles("*.jpg");
            listBoxViewPictures.Items.Clear();
            foreach (FileInfo fileInfo in fileInfos)
            {
                listBoxViewPictures.Items.Add(fileInfo.Name);
            }
            labelFolderPath.Text = path;
            if (fileInfos.Length == 0)
            {
                return false;
            }
            else
            {
                listBoxViewPictures.SelectedIndex = 0;
                return true;
            }
        }

        private void listBoxViewPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            double scaleWidth;
            double scaleHeight;

            pictureBoxViewPictures.Visible = false;
            pictureBoxViewPictures.Left = pictureBoxCoordinateX;
            pictureBoxViewPictures.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxViewPictures.Image = new Bitmap(folderPath + "\\" + listBoxViewPictures.SelectedItem.ToString());

            if ((pictureBoxViewPictures.Image.Width > pictureBoxWidth) || (pictureBoxViewPictures.Image.Height > pictureBoxHeight))
            {
                pictureBoxViewPictures.SizeMode = PictureBoxSizeMode.StretchImage;
                scaleWidth = (double)pictureBoxWidth / (double)pictureBoxViewPictures.Image.Height;
                scaleHeight = (double)pictureBoxWidth / (double)pictureBoxViewPictures.Image.Height;
                if (scaleHeight< scaleWidth)
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

        private void buttonBrowseFolders_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку, \n" + "в которой находятся иллюстрации";
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                labelFolderPath.Text = folderPath;
                if (!FillListBox(folderPath))
                {
                    pictureBoxViewPictures.Image = null;
                }
            }
        }
    }
}
