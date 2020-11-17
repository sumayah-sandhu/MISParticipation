using System;
using System.Collections.Generic;
using System.Xml;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            

            

            Console.WriteLine("Please enter an animal, you can choose between a goat,monkey, or dog!");
            
            speak();

            Console.ReadKey();
           
            static void speak()

            {

                List<string> animalnoises = new List<string>();
                string dognoise = "barking noise:'woof' ";
                string goatnoise = "bleating noise: 'baaaaa'";
                string monkeynoise = "screeching noise: oooh aaahh";
                string animaltypeinput = Console.ReadLine();
                string animaltype = animaltypeinput.ToLower();

                animalnoises.AddRange(new List<string> { dognoise, goatnoise, monkeynoise });

                if (animaltype == "dog")
                {
                    string listdog = animalnoises[0];
                    Console.WriteLine(listdog);
                }

                else if (animaltype == "goat")
                {
                    string listgoat = animalnoises[1];
                    Console.WriteLine(listgoat);
                }

                else if (animaltype == "monkey")
                {
                    string listmonkey = animalnoises[2];
                    Console.WriteLine(listmonkey);
                }
                else
                {
                    Console.WriteLine("That was not a valid animal type, sorry.");

                }

            
            
            
            
            
            }


        }
    }
}
