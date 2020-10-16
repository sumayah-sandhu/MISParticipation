using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingaCSVfile_2
{
    class Program
    {
        static void Main(string[] args)
        {

            String filepath = @"SalesJan2009.csv";
            String[] lines = File.ReadAllLines(filepath);

           

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] splitlines = line.Split(',');
                string name = splitlines[4];
                string transdate = splitlines[0];

                if (splitlines[3].ToLower() == "visa" & splitlines[7].ToLower() == "united states")
                {


                    Console.WriteLine(name + " " + transdate);
                    


                }

            }

            Console.ReadKey(); 
        }
    }
}
