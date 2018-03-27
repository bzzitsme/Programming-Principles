using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample3
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath gp = new GraphicsPath();
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void button1_Click(object sender, PaintEventArgs e)
        {
            gp.AddLine(10, 10, 100, 100);
            gp.AddEllipse(20, 30, 50, 50);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawPath(new Pen(Color.Red, 5), gp);
        }
    }
}
