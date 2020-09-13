using System;
using System.Globalization;

namespace Conditional_Coin_Toss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
          
            int Number = rand.Next(1, 3);
          
            Console.WriteLine("Heads or Tails? >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;
            const int headsnumber = 1;
            const int tailsnumber = 2;

            if (usersGuessAsString == "Heads")
            {
                usersGuess = headsnumber;
            }
            else if (usersGuessAsString == "Tails")
            {
                usersGuess = tailsnumber;
            }
            else
            {
                Console.WriteLine("Invalid");
                
                return;
           
            }



            if (usersGuess == Number)
            {
                Console.WriteLine($"It landed on {usersGuessAsString} you are correct");
            }
            else
            {
                if (usersGuess == 1)
                {
                    Console.WriteLine($"Sorry, your answer {usersGuessAsString} is incorrect, Tails was the correct answer.");
                   
                }
                else
                {
                    Console.WriteLine($"Sorry, your answer {usersGuessAsString} in incorrect, Heads was the correct answer.");
                }

                const string developername = "Sumayah";
                {

                    Console.WriteLine($"Developed by {developername}" );
                }

               
            }
        }
    }
}
                
           

          




        

 
