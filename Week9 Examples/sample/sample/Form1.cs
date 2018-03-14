using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation = "blue";
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (operation == "blue")
            {
                BackColor = Color.Blue;
                operation = "yellow";
            }
            else if (operation == "yellow")
            {
                BackColor = Color.Yellow;
                operation = "red";
            }
            else if (operation == "red")
            {
                BackColor = Color.Red;
                operation = "blue";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
