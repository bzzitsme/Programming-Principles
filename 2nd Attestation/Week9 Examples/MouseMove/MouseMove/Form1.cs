using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            int x = new Random().Next(0, 400);
            int y = new Random().Next(0, 400);
            btn.Location = new Point(x, y);
            // MessageBox.Show("Mouse Hover");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            int x = new Random().Next(0, 400);
            int y = new Random().Next(0, 400);
            btn.Location = new Point(x, y);
        }
    }
}
