using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class CircleForm : Form
    {
        int radius,radius2;
        int x1, x2, y1, y2;

        bool mouseClick=false;
        bool mouseDown=false;
        Pen myPen = new Pen(Color.Red);

        public CircleForm(int radius)
        {
            InitializeComponent();
            this.radius = radius;
            this.radius2 = radius;
        }


        private void circlebutton_Click(object sender, EventArgs e)
        {
            CircleShape circle = new CircleShape(radius);
            circlelabel.Text = circle.Print(circle.CalculateArea(), circle.CalculatePerimeter());
            this.mouseClick = true;
        }

        private void circlepictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (mouseClick)
            {
                e.Graphics.DrawEllipse(myPen, x1, y1, radius, radius2);
            }
            circlepictureBox.Refresh();

        }

        private void circlepictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseClick)
            {
                x1 = e.X;
                y1 = e.Y;
                mouseDown = true;
            }
        }


        private void circlepictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                x2 = e.X;
                y2 = e.Y;
                radius = Math.Abs(x2 - x1);
                radius2 = Math.Abs(y2 - y1);
            }
        }
     
        private void circlepictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
