using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Rectangle_Circle
{
    public class Circle
    {
        public double Radius;
        public const double PI = 3.1415926535897931;
        public Circle()

        {
            Radius = 0;
        }

        public Circle(double Radius)
        {
            this.Radius = Radius; 
        }

        public double CalculateArea()
        {
            double circlearea = PI * (Radius * Radius);

            return circlearea; 
        }

        public double CalculatePerimeter()

        {
            double circleperimeter = (2 * PI)*(Radius);

            return circleperimeter; 
        }
    
    
    }
}
