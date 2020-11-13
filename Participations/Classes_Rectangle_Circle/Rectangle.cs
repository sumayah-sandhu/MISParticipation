using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Rectangle_Circle
{
    public class Rectangle
    {
        public double Width;
        public double Length;

        public Rectangle()

        {
            Width = 0;
            Length = 0;
        }

        public Rectangle(double Length, double Width)
        {
            this.Width = Width;
            this.Length = Length;

        }

        public double CalculateArea()

        {
            double area = Width * Length;

            return area;
        }
         

        public double CalculatePerimeter()

        {
             
            double perimeter = 2*(Width + Length);

            return perimeter; 
        }
    
    
    
    }
       
}
