using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace String_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Programming today is a race between software engineers striving to " +
                "build bigger and better idiot-proof programs, and the universe trying to build " +
                "bigger and better idiots. So far, the universe is winning.";

            Console.WriteLine(sentence);

            Console.WriteLine("What word do you want to look for in the above sentence?");
            string word = Console.ReadLine();

            Console.WriteLine($"What word do you want to change {word} to?");
            string changedword = Console.ReadLine();
            string reverseword = ""; 
            for (int i = word.Length - 1; i>=0; i--)
            {
                reverseword = reverseword + word[i];
            }

            bool b = sentence.Contains(word);

            string newsentence = "hi";
            if (b == true)

            {
               newsentence = sentence.Replace(word,changedword);
               Console.WriteLine(newsentence); 
            }

            else

            {
                Console.WriteLine($"Sorry I could not find your word {word}.");
                Console.WriteLine(reverseword);

            }



            Console.ReadKey(); 

            
        }  
        
    }
}
