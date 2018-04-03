using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphucsExample6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp1;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp1 = new Bitmap(@"C:\Users\Admin\Desktop\sfdghjkl\asd.jpg");
            Bitmap bmp2 = new Bitmap(bmp1.Width, bmp1.Height);
            Bitmap bmp3 = new Bitmap(bmp1.Width, bmp1.Height);
            Bitmap bmp4 = new Bitmap(bmp1.Width, bmp1.Height);
            Bitmap bmp5 = new Bitmap(bmp1.Width, bmp1.Height);
            for(int i = 0; i < bmp1.Width;i ++)
            {
                for(int j = 0; j < bmp1.Height; j++)
                {
                    Color pix = bmp1.GetPixel(i, j);
                    Color red = Color.FromArgb(200, pix.G, pix.B);
                    Color green = Color.FromArgb(0, pix.G, 0);
                    Color blue = Color.FromArgb(0, 0, pix.B);
                    bmp2.SetPixel(i, j, red);
                    bmp3.SetPixel(i, j, green);
                    bmp4.SetPixel(i, j, blue);
                    int grey = (pix.R + pix.G + pix.B) / 3;
                    bmp5.SetPixel(i, j, Color.FromArgb(grey, grey, grey));

                }
                pictureBox1.Image = bmp1;
                pictureBox2.Image = bmp2;
                pictureBox3.Image = bmp3;
                pictureBox4.Image = bmp4;
                pictureBox5.Image = bmp5;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Color pix = bmp1.GetPixel(e.X, e.Y);
            label1.Text = pix.R + " " + pix.G + " " + pix.B;
        }
    }
}
