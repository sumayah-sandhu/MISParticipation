using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            if (number % 5 == 0 && number % 3 == 0)




            {
                Console.WriteLine("Fizz Buzz");
            }



            else if (number % 3 == 0)

            {
                Console.WriteLine("Fizz");

            }


            else if (number % 5 == 0)

            {
                Console.WriteLine("Buzz");

            }











            else Console.WriteLine(number);
        }
    }
}
