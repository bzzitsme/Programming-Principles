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

namespace Asteroid
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = 450, y = 350, z = 0;
        Pen p = new Pen(Color.Black, 10);
        SolidBrush brush = new SolidBrush(Color.Blue);
        SolidBrush star = new SolidBrush(Color.White);
        SolidBrush asteroids = new SolidBrush(Color.Red);
        SolidBrush SpaceShip = new SolidBrush(Color.Yellow);
        SolidBrush Gun = new SolidBrush(Color.Green);
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            //MessageBox.Show("constructor");
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillRectangle(brush, 0, 0, Width, Height);
            g.DrawRectangle(p, 0, 0, Width - 15, Height - 40);
            g.FillEllipse(star, 50, 80, 30, 30);
            g.FillEllipse(star, 80, 370, 30, 30);
            g.FillEllipse(star, 250, 60, 30, 30);
            g.FillEllipse(star, 440, 120, 30, 30);
            g.FillEllipse(star, 640, 200, 30, 30);
            g.FillEllipse(star, 560, 260, 30, 30);
            g.FillEllipse(star, 620, 400, 30, 30);
            g.FillEllipse(star, 260, 280, 30, 30);
            // asteroid 1
            Point[] asteroid1 = { new Point(120, 150), new Point(170, 150), new Point(145, 180), };
            Point[] asteroid2 = { new Point(120, 170), new Point(145, 140), new Point(170, 170) };
            g.FillPolygon(asteroids, asteroid1);
            g.FillPolygon(asteroids, asteroid2);
            // asteroid 2
            Point[] asteroid3 = { new Point(150, 250), new Point(200, 250), new Point(175, 280), };
            Point[] asteroid4 = { new Point(150, 270), new Point(175, 240), new Point(200, 270) };
            g.FillPolygon(asteroids, asteroid3);
            g.FillPolygon(asteroids, asteroid4);
            // asteroid 3
            Point[] asteroid5 = { new Point(520, 120), new Point(570, 120), new Point(545, 150), };
            Point[] asteroid6 = { new Point(520, 140), new Point(545, 110), new Point(570, 140) };
            g.FillPolygon(asteroids, asteroid5);
            g.FillPolygon(asteroids, asteroid6);
            // asteroid 4
            Point[] asteroid7 = { new Point(x, y), new Point(x + 50, y), new Point(x + 25, y + 30), };
            Point[] asteroid8 = { new Point(x, y + 20), new Point(x + 25, y - 10), new Point(x + 50, y + 20) };
            g.FillPolygon(asteroids, asteroid7);
            g.FillPolygon(asteroids, asteroid8);
            // SpaceShip
            Point[] spaceshipup = { new Point(340, 240), new Point(380, 220), new Point(420, 240) };
            g.FillPolygon(SpaceShip, spaceshipup);
            g.FillRectangle(SpaceShip, 340, 240, 80, 30);
            Point[] spaceshipbottom = { new Point(340, 270), new Point(380, 290), new Point(420, 270) };
            g.FillPolygon(SpaceShip, spaceshipbottom);
            // Gun
            Point[] weapon = { new Point(370, 255), new Point(380, 240), new Point(390, 255) };
            g.FillPolygon(Gun, weapon);
            g.FillRectangle(Gun, 375, 255, 10, 15);
            // Bullet
        }



    }
}
