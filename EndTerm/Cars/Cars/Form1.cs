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

namespace Cars
{
    public partial class Form1 : Form
    {
        class Car
        {
            int x, y;
            GraphicsPath gp1, gp2;
            public Car(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void Draw(GraphicsPath gp1, GraphicsPath gp2)
            {
                gp1.FillMode
            }
            public void Function()
            {
                gp1 = new GraphicsPath();
                gp1.AddRectangle(new Rectangle(x, y, 100, 100));
                gp1.AddRectangle(new Rectangle(x - 50, y - 50, 200, 200));
                Draw(gp1, gp2);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        int x = 50, y = 50;
        Car car = new Car(50, 50);
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
