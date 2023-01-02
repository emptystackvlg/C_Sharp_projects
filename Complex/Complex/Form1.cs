using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VideoLibrary;
namespace Complex
{
    public partial class ComplexForm : Form
    {
        
        public ComplexForm()
        {
            InitializeComponent();
        }

        private void buttonAlgToExp_Click(object sender, EventArgs e)
        {
            if (textBoxRe.Text == "" || textBoxIm.Text == "")
            {
                MessageBox.Show("Введите данные", "Пустое поле ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxRe.Text = textBoxRe.Text.Replace('.',',');
            textBoxIm.Text = textBoxIm.Text.Replace('.', ',');
            textBoxToModule.Text = "";
            textBoxToAngle.Text = "";
            double x = Convert.ToDouble(textBoxRe.Text);
            double y = Convert.ToDouble(textBoxIm.Text);
            double Angle = Math.Round (Math.Atan(y/x) * 180 / Math.PI,3);
            if (x < 0 && y > 0)
            {
                Angle += 180;
            }
            else if (x < 0 && y < 0)
            {
                Angle -= 180;
            }
            double Module = Math.Round (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),3);
            textBoxToModule.Text = Convert.ToString(Module);
            textBoxToAngle.Text = Convert.ToString(Angle);
            GC.Collect();
        }
        void SaveVideoToDisk(string link)
        { 
            var youTube = YouTube.Default; // starting point for YouTube actions
            var video = youTube.GetVideo(link); // gets a Video object with info about the video
            File.WriteAllBytes(@"D:\" + video.FullName, video.GetBytes());
        }

        private void buttonExpToAlg_Click(object sender, EventArgs e)
        {
            textBoxToAlg.Text = "";
            String ArithmeticSign = " + ";
            if (textBoxMod.Text == "" || textBoxAng.Text == "")
            {
                MessageBox.Show("Введите данные", "Пустое поле ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveVideoToDisk("https://www.youtube.com/watch?v=uTEPCT9qHkM");
            textBoxMod.Text = textBoxMod.Text.Replace('.', ',');
            textBoxAng.Text = textBoxAng.Text.Replace('.', ',');
            double Mod = Convert.ToDouble(textBoxMod.Text);
            double Ang = Convert.ToDouble(textBoxAng.Text);
            double Re = Math.Round (Mod*Math.Cos (Ang * Math.PI / 180),3);
            double Im = Math.Round (Mod*Math.Sin (Ang*Math.PI / 180),3);
            if (Im < 0)
            {
                ArithmeticSign = " - ";
                Im = Math.Abs (Im);
            }
            textBoxToAlg.Text = Convert.ToString(Re) + ArithmeticSign+ Convert.ToString (Im) + "j";
            GC.Collect();
        }   
    }
}
