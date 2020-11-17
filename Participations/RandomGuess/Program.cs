using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your maximum value.");
            string maxinput = Console.ReadLine();
            int maxvalue = Convert.ToInt32(maxinput);


            Console.WriteLine("Please enter your minimum value.");
            string mininput = Console.ReadLine();
            int minvalue = Convert.ToInt32(mininput);

            Random rnd = new Random();
            int number = rnd.Next(minvalue + 1, maxvalue);

            Console.WriteLine("Please guess a value that is between your minimum and maximum values.");

            int guess = Convert.ToInt32(Console.ReadLine());
                       
            while (guess != number)

            {
                Console.WriteLine($"{guess} is incorrect, please try again.");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Congratulations! {number} is correct!");

            Console.ReadLine(); 

            
            
            
            
            
            
            
            
            
            
            







            }
        }
    }

