using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = CreateGraphics();

            Pen pen = new Pen(Color.BlueViolet);
            pen.Width = 6.2f;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //Point starPoint = new Point(45, 45);
            //Point endPoint = new Point(180, 150);
            //g.DrawLine(pen, starPoint, endPoint);
            //g.DrawLine(pen, 190, 60, 65, 170);

            //Rectangle rect = new Rectangle(50, 50, 150, 100);
            Graphics g = CreateGraphics();
            Rectangle[] rects = new Rectangle[]
            {
                new Rectangle(40,40,40,100),
                new Rectangle(100,40,100,40),
                new Rectangle(100,100,100,40)
            };
            g.FillRectangles(Brushes.YellowGreen, rects);
            g.DrawRectangles(pen, rects);
        }
            
            
        }
    }

