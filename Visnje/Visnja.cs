using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visnje
{
    internal class Visnja
    {
        private int x, y, a;
        private Point o;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public void Crtaj(Graphics g)
        {
            Pen Pen1 = new Pen(Color.LightGreen, 3);
            g.DrawLine(Pen1, new Point(x, y), new Point(x - a, y + 2 * a));
            g.DrawLine(Pen1, new Point(x, y), new Point(x + a, y + 2 * a));
            SolidBrush Brush1 = new SolidBrush(Color.Green);
            g.FillEllipse(Brush1, x, y - a / 4, a, a / 2);
            SolidBrush Brush2 = new SolidBrush(Color.Red);
            g.FillEllipse(Brush2, x + a / 2, y + 3 * a / 2, a, a);
            g.FillEllipse(Brush2, x - 3 * a / 2, y + 3 * a / 2, a, a);

        }

        public Visnja(int a, int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.A = a;
        }

        public void del()
        {
            A = 0;
            X = 0;
            Y = 0;

        }

        public bool container(Point o)
        {
            if (o.X > x - 3 * a / 2 && o.X < x + 3 * a / 2)
            {
                if (o.Y > y - a / 4 && o.Y < y + 5 * a / 2)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
