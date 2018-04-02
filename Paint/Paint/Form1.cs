using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics bmpGraphics;
        Point prev, cur;
        string operation = "";
        int size = 1;
        Pen pen = new Pen(Color.Black, 1);
        bool click = false;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            bmpGraphics = Graphics.FromImage(bmp);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(operation == "rectangle")
            {
                
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawRectangle(pen, x, y, w, h);
                lol = true;
                pictureBox1.Refresh();
            }
            else if(operation == "circle")
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawEllipse(pen, x, y, w, h);
                lol = true;
                pictureBox1.Refresh();
            }
            else if(operation == "line")
            {
                e.Graphics.DrawLine(pen, prev, cur);
                lol = true;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if(click)
            {
                if(operation == "" || operation == "pen")
                {
                    bmpGraphics.DrawLine(pen, prev.X, prev.Y, cur.X, cur.Y);
                    prev = cur;
                    pictureBox1.Refresh();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
            if(operation == "rectangle")
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                bmpGraphics.DrawRectangle(pen, x, y, w, h);
            }
            else if(operation == "circle")
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                bmpGraphics.DrawEllipse(pen, x, y, w, h);
            }
            else if(operation == "line")
            {
                bmpGraphics.DrawLine(pen, prev, cur);
            }
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation = "rectangle";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.DarkBlue, size);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Green, size);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Yellow, size);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, size);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, size);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, size);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.White, size);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Gray, size);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.YellowGreen, size);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Magenta, size);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation = "circle";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "fill";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation = "erase";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = "pen";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation = "line";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            prev = e.Location;
        }
    }
}
