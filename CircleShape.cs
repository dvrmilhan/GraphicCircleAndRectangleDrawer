using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CircleShape : Shape, IShape 
    {

        int radius;

        public CircleShape(int radius)
        {
           this.radius = radius;
        }
        public override string Print(double area, double perimeter)
        {
            return "Area :  "+area +"  Perimeter :  " + perimeter;
        }


        public double CalculateArea()
        {
            return radius*radius*Math.PI;
        }
        public double CalculatePerimeter()
        {
            return 2*Math.PI*radius;
        }
    }
}
