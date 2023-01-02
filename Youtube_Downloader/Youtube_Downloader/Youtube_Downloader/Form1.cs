using System;
using System.IO;
using VideoLibrary;
using System.Windows.Forms;

namespace Youtube_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите ссылку на видео", "Пустое поле ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string link = textBox1.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                var youTube = YouTube.Default;
                var video = youTube.GetVideo(link); 
                File.WriteAllBytes(path + video.FullName, video.GetBytes());

            }

        }
    }
}
