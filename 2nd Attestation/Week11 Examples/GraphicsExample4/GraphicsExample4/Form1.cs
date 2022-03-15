﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample4
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();

        }
        Tank t = new Tank(50, 50);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                t.direction = 1;
            if (e.KeyCode == Keys.D)
                t.direction = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t.direction == 0)
                t.x += 2;
            else t.y += 2;
            g.Clear(Color.White);
            t.Draw(g);
        }
    }
}
