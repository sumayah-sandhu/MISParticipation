using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Rectangle_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle first = new Rectangle(24, 12);

           double firstarea = first.CalculateArea();

            Console.WriteLine($"The area of the first rectangle is {firstarea}");

            Rectangle second = new Rectangle(12.34, 67.55);

            double secondarea = second.CalculateArea();

            Console.WriteLine($"The area of the second rectange is {secondarea.ToString("N2")}");

            double firstperimeter = first.CalculatePerimeter();

            Console.WriteLine($"The perimeter of the first rectangle is {firstperimeter}");

            double secondperimeter = second.CalculatePerimeter();

            Console.WriteLine($"The perimeter of the second rectangle is {secondperimeter.ToString("N2")}");


            Circle firstcircle = new Circle(6);

            double firstcirclearea = firstcircle.CalculateArea();

            Console.WriteLine($"The area of the first circle is {firstcirclearea.ToString("N2")}");

            Circle secondcircle = new Circle(7.43);

            double secondcirclearea = secondcircle.CalculateArea();

            Console.WriteLine($"The area of the second circle is {secondcirclearea.ToString("N2")}");

            double firstcircleperimeter = firstcircle.CalculatePerimeter();

            Console.WriteLine($"The perimeter of the first circle is {firstcircleperimeter.ToString("N2")}");

            double secondcircleperimeter = secondcircle.CalculatePerimeter();

            Console.WriteLine($"The perimeter of the second circle is {secondcircleperimeter.ToString("N2")}"); 


            Console.ReadKey(); 
        }
    }
}
