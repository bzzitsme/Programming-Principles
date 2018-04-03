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
        int size = 1;
        Pen pen = new Pen(Color.Black, 1);
        bool click = false;
        Tool tool;
        Queue<Point> q;
        Color clr = Color.Black;
        Color org;
        Color curr;
        Image file;
        public enum Tool
        {
            PEN,
            RECTANGLE,
            ELLIPSE,
            ERASE,
            LINE,
            FILL
        }
        public Form1()
        {
            InitializeComponent();
            tool = Tool.PEN;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            bmpGraphics = Graphics.FromImage(bmp);
            q = new Queue<Point>();
            bmpGraphics.Clear(Color.White);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(click && tool == Tool.RECTANGLE)
            {
                
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawRectangle(pen, x, y, w, h);
            }
            if(click && tool == Tool.ELLIPSE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawEllipse(pen, x, y, w, h);
                pictureBox1.Refresh();
            }
            if(click && tool == Tool.LINE)
            {
                e.Graphics.DrawLine(pen, prev, cur);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if(click && tool == Tool.PEN)
            {
                    bmpGraphics.DrawLine(pen, prev.X, prev.Y, cur.X, cur.Y);
                    prev = cur;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            prev = e.Location;
            if(tool == Tool.FILL)
            {
                q.Enqueue(e.Location);
                org = bmp.GetPixel(e.X, e.Y);
                curr = clr;
                while(q.Count > 0)
                {
                    
                    int x = q.First().X;
                    int y = q.First().Y;
                    q.Dequeue();
                    Step(x + 1, y);
                    Step(x, y + 1);
                    Step(x - 1, y);
                    Step(x, y - 1);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if(f.ShowDialog() == DialogResult.OK)
            {
                file.Save(f.FileName);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if(f.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                // pictureBox1.Image = file;
                bmpGraphics.DrawImage(file, 0, 0);
                pictureBox1.Refresh();
            }
        }
        void Step(int x, int y)
        {
            if (x >= bmp.Width)
                return;
            if (x < 0)
                return;
            if (y >= bmp.Height)
                return;
            if (y < 0)
                return;
            if (bmp.GetPixel(x, y) != org)
                return;
            bmp.SetPixel(x, y, curr);
            q.Enqueue(new Point(x, y));
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
            if(tool == Tool.RECTANGLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                bmpGraphics.DrawRectangle(pen, x, y, w, h);
            }
            if(tool == Tool.ELLIPSE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                bmpGraphics.DrawEllipse(pen, x, y, w, h);
            }
            if(tool == Tool.LINE)
            {
                bmpGraphics.DrawLine(pen, prev, cur);
            }
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.RECTANGLE;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.DarkBlue, size);
            clr = Color.DarkBlue;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Green, size);
            clr = Color.Green;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Yellow, size);
            clr = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, size);
            clr = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, size);
            clr = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, size);
            clr = Color.Blue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.White, size);
            clr = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Gray, size);
            clr = Color.Gray;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.YellowGreen, size);
            clr = Color.YellowGreen;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Magenta, size);
            clr = Color.Magenta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tool = Tool.ELLIPSE;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tool = Tool.FILL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.ERASE;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tool = Tool.PEN;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value;
            pen = new Pen(clr, size);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bmpGraphics.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tool = Tool.LINE;
        }

    }
}
