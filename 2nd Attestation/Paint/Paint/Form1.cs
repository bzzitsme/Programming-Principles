using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Point previous, current;
        int size = 1;
        Pen Pencil = new Pen(Color.Black, 1);
        bool clicked = false;
        Queue<Point> queue;
        Color colour = Color.Black;
        Color Original;
        Color Current;
        Image File;
        TOOL tool;
        public enum TOOL
        {
            PEN,
            RECTANGLE,
            ELLIPSE,
            FILL,
            LINE,
        }
        public Form1()
        {
            InitializeComponent();
            tool = TOOL.PEN;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            queue = new Queue<Point>();
            g.Clear(Color.White);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            previous = e.Location;
            if(tool == TOOL.FILL)
            {
                queue.Enqueue(e.Location);
                Original = bmp.GetPixel(e.X, e.Y);
                Current = colour;
                while(queue.Count() > 0)
                {
                    int x = queue.First().X;
                    int y = queue.First().Y;
                    queue.Dequeue();
                    QueueStuff(x + 1, y);
                    QueueStuff(x, y + 1);
                    QueueStuff(x - 1, y);
                    QueueStuff(x, y - 1);
                }
                pictureBox1.Image = bmp;
            }
        }

        private void QueueStuff(int x, int y)
        {
            if (x >= bmp.Width) return;
            if (y >= bmp.Height) return;
            if (x < 0) return;
            if (y < 0) return;
            if (bmp.GetPixel(x, y) != Original) return;
            bmp.SetPixel(x, y, Current);
            queue.Enqueue(new Point(x, y));
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            if(tool == TOOL.RECTANGLE)
            {
                int x = Math.Min(previous.X, current.X);
                int y = Math.Min(previous.Y, current.Y);
                int w = Math.Abs(previous.X - current.X);
                int h = Math.Abs(previous.Y - current.Y);
                g.DrawRectangle(Pencil, x, y, w, h);
            }
            if(tool == TOOL.ELLIPSE)
            {
                int x = Math.Min(previous.X, current.X);
                int y = Math.Min(previous.Y, current.Y);
                int w = Math.Abs(previous.X - current.X);
                int h = Math.Abs(previous.Y - current.Y);
                g.DrawEllipse(Pencil, x, y, w, h);
            }
            if(tool == TOOL.LINE)
            {
                g.DrawLine(Pencil, previous, current);
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            current = e.Location;
            if(clicked && tool == TOOL.PEN)
            {
                g.DrawLine(Pencil, previous, current);
                previous = current;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(clicked && tool == TOOL.RECTANGLE)
            {
                int x = Math.Min(previous.X, current.X);
                int y = Math.Min(previous.Y, current.Y);
                int w = Math.Abs(previous.X - current.X);
                int h = Math.Abs(previous.Y - current.Y);
                e.Graphics.DrawRectangle(Pencil, x, y, w, h);
            }
            if(clicked && tool == TOOL.ELLIPSE)
            {
                int x = Math.Min(previous.X, current.X);
                int y = Math.Min(previous.Y, current.Y);
                int w = Math.Abs(current.X - previous.X);
                int h = Math.Abs(current.Y - previous.Y);
                e.Graphics.DrawEllipse(Pencil, x, y, w, h);
            }
            if(clicked && tool == TOOL.LINE)
            {
                e.Graphics.DrawLine(Pencil, previous, current);
            }
        }

        private void Button_Pen_Click(object sender, EventArgs e)
        {
            tool = TOOL.PEN;
        }

        private void Button_Ellipse_Click(object sender, EventArgs e)
        {
            tool = TOOL.ELLIPSE;
        }

        private void Button_Rectangle_Click(object sender, EventArgs e)
        {
            tool = TOOL.RECTANGLE;
        }

        private void Button_Line_Click(object sender, EventArgs e)
        {
            tool = TOOL.LINE;
        }

        private void Button_Fill_Click(object sender, EventArgs e)
        {
            tool = TOOL.FILL;
        }

        private void Button_Erase_Click(object sender, EventArgs e)
        {
            Pencil = new Pen(Color.White, size);
            tool = TOOL.PEN;
        }

        private void Button_Colour(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string s = button.Name;
            colour = Color.FromName(s);
            Pencil = new Pen(colour, size);
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colour = colorDialog1.Color;
            Pencil = new Pen(colour, size);
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.JPG)|*.JPG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.OpenFile();
                bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
                g = Graphics.FromImage(bmp);

            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = TOOL.RECTANGLE;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            size = TrackBar.Value;
            Pencil = new Pen(colour, size);
        }
    }
}
