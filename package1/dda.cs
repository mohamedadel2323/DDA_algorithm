using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace package1
{
    public partial class dda : Form
    {
        public dda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(text1.Text);
            int y1 = Convert.ToInt32(text2.Text);

            int x2 = Convert.ToInt32(text3.Text);
            int y2 = Convert.ToInt32(text4.Text);
            lineDDA(x1, y1, x2, y2);



        }
        void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)(dx) / (float)(steps);
            yIncrement = (float)(dy) / (float)(steps);

            var brush = Brushes.Black;
            var g = panel.CreateGraphics();

            g.FillRectangle(brush, x, y, 2, 2);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(brush, x, y, 2, 2);
            }
        }


    }
}
