using System;

namespace Classes_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy first = new Toy("lego", "blocks", 14, "for my child");

            string firstry = first.GetAisle();

            Console.WriteLine(firstry);

            Toy second = new Toy("nintendo", "switch", 200, "nintendo game console");

            string secondtry = second.GetAisle();
            
            Console.WriteLine(secondtry);
            
        }
    }
}
