using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample2
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            g.Clear(Color.Blue);
            g.DrawRectangle(new Pen(Color.Red, 5), x, y, 50, 50);
        }
    }
    }
