using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionsminmaxavg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many exam grades would you like to enter?");
            int numberofgrades = Convert.ToInt32(Console.ReadLine());
            
            double[] examgrades = new double[numberofgrades];
            Console.WriteLine("Please enter your first grade");
            double firstgrade = Convert.ToDouble(Console.ReadLine());
            examgrades[0] = firstgrade;
            int n = 0;
            double min = examgrades[0];
            double max = examgrades[0];
            
            for(int i = 0; i < numberofgrades - 1; i++) 
            
            {
                Console.WriteLine("Please enter your next grade");
                n = n + 1;
                examgrades[n] = Convert.ToDouble(Console.ReadLine());

            }



            for (int i = 1; i < examgrades.Length; i++)
            {
                if (min > examgrades[i])
                {
                    min = examgrades[i];
                }
                    
               
            }

            for (int i = 0; i < examgrades.Length; i++)
            {
                if (max < examgrades[i])
                {
                    max = examgrades[i];
                }   
                   
            }
            double avg = examgrades.Average();

            double minexam = min / 100;
            double maxexam = max / 100;
            double avgexam = avg / 100; 


            Console.WriteLine($"Your minimum exam grade is {minexam.ToString("P2")}");
            Console.WriteLine($"Your maximum exam grade is {maxexam.ToString("P2")}");
            Console.WriteLine($"Your average exam grade is {avgexam.ToString("P2")}");

            Console.ReadLine(); 

        }
    }
}
