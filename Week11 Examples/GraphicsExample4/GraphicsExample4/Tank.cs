﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsExample4
{
    class Tank
    {
        public GraphicsPath gp;
        public int direction = 0;
        public int x, y;
        public Tank(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw(Graphics g)
        {
            gp = new GraphicsPath();
            int w = 30;
            int h = 30;
            gp.AddRectangle(new Rectangle(x, y, w, h));
            gp.AddEllipse(new Rectangle(x, y, w, h));
            if(direction == 0)
            {
                gp.AddLine(x + w / 2 , y + h / 2, x + w + w / 2, y + h / 2);
            }
            if(direction == 1)
            {
                gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h + h / 2);
            }
            g.DrawPath(new Pen(Color.Red, 3), gp);
        }
    }
}
