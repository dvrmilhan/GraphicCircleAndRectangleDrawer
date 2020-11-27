using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class RectangleShape: Shape,IShape
    {
        int edge1,edge2;


        public RectangleShape(int edge1,int edge2)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
        }

        public override string Print(double area, double perimeter)
        {
            return "Area  :   " + area +"  Perimeter :  " + perimeter;
        }


        public double CalculateArea()
        {
            return edge1*edge2;
        }
        public double CalculatePerimeter()
        {
            return (edge1+edge2)*2;
        }
    }
}
