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
    public partial class RectangleForm : Form
    {
         int edge1;
         int edge2;
        int x1, x2, y1, y2;

        bool mouseClick = false;
        bool mouseDown = false;
        Pen myPen = new Pen(Color.Red);

        private void rectanglepictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseClick)
            {
                x1 = e.X;
                y1 = e.Y;
                mouseDown = true;
            }
        }

        private void rectanglepictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void rectanglepictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                x2 = e.X;
                y2 = e.Y;
                edge1 = Math.Abs(x2 - x1);
                edge2 = Math.Abs(y2 - y1);
            }
        }

      
        public RectangleForm(int edge1,int edge2)
        {
            InitializeComponent();
            this.edge1 = edge1;
            this.edge2 = edge2;
        }

        private void rectanglebutton1_Click(object sender, EventArgs e)
        {
            RectangleShape rectangle = new RectangleShape(edge1,edge2);
            rectanglelabel1.Text = rectangle.Print(rectangle.CalculateArea(), rectangle.CalculatePerimeter());
            this.mouseClick = true;
        }
        private void rectanglepictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (mouseClick)
            {
                e.Graphics.DrawRectangle(myPen, x1, y1, edge1, edge2);
            }
            rectanglepictureBox1.Refresh();

        }
    }
}
