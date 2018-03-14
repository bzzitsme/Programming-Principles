using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorobkiSNeba
{
    public partial class Form1 : Form
    {
        int dx = 1;
        bool test = true;
        Button button = new Button();
        Random rnd = new Random();
        List<Button> vector = new List<Button>();
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int xx = rnd.Next(0, Width - (Width - 275));
            int yy = rnd.Next(0, 40);
            Button btn1 = new Button();
            btn1.Location = new Point(xx, yy);
            btn1.Size = new Size(35, 35);
            btn1.Text = "#";
            if(test)
            {

                vector.Add(btn1);
                Controls.Add(btn1);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(test)
            {
                for(int i = 0; i < vector.Count(); i++)
                {
                    vector[i].Location = new Point(vector[i].Location.X, vector[i].Location.Y + 3);
                    if (vector[i].Location.Y == 300)
                    {
                        vector[i].Hide();
                        vector.RemoveAt(i);
                        score += 1;
                        label1.Text = "Score " + score;
                    }
                    else if (vector[i].Location.Y > button1.Location.Y + 35)
                    {
                        vector[i].Hide();
                        vector.RemoveAt(i);
                    }
                    else if (Math.Abs(vector[i].Location.Y - button1.Location.Y) <= 35 && Math.Abs(vector[i].Location.X - button1.Location.X) <= 35)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        MessageBox.Show("Game Over noob");
                        test = false;
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (test)
            {
                button1.Location = new Point(trackBar1.Value, button1.Location.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (e.KeyChar.ToString() == "A")
            {
                x -= dx;
                button.Location = new Point(x, y);
            }
            if (e.KeyChar.ToString() == "D")
            {
                x += dx;
                button.Location = new Point(x, y);
            } */
        }
    }
}
