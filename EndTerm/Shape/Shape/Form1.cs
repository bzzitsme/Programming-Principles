using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form1 : Form
    {
        int x, y;
        int p = 10;
        int d = 10;
        int sizea = 50;
        int sizeb = 50;
        int cnt = 0;
        class Shape
        {
            float x, y, w, h;
            Pen pencil;
            public Shape(float x, float y, float w, float h, Color color)
            {
                this.x = x;
                this.y = y;
                this.w = w;
                this.h = h;
                pencil = new Pen(color, 5);

            }
            public void Draw(Graphics g)
            {
                g.DrawEllipse(pencil, x, y, w, h);
            }
        }

        string[] colors = { "cyan", "blue", "red", "purple" };

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, colors.Length);
            Shape shapee = new Shape(x - 25, y - 25, sizea, sizeb, Color.FromName(colors[i]));
            Graphics g = CreateGraphics();
            shapee.Draw(g);
            cnt++;
            if (cnt % 2 == 0)
            {
                Shape shape = new Shape(x - 25, y - 25, sizea + p, sizeb + d, Color.FromName(colors[i]));
                Graphics gg = CreateGraphics();
                p += 10;
                d+= 10;
                shape.Draw(gg);
            }

        }
    }
}
