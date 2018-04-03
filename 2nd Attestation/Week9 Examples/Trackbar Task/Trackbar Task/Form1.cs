using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackbar_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Location = new Point(trackBar1.Value + 15, label1.Location.Y);
            // button1.Size = new Size(trackBar1.Value, trackBar1.Value);
            label1.Font = new Font("Arial", trackBar1.Value);
        }
    }
}
