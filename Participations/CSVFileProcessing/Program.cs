using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSVFileProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"sales_data_sample.csv";

            string[] columns = File.ReadAllLines(filepath);
            double sum = 0;
            double sumfor2003 = 0;
            double sumfor2004 = 0;
            double sumfor2005 = 0;
            double sumforjan = 0;
            double sumforfeb = 0;
            double sumformar = 0;
            double sumforapr = 0;
            double sumformay = 0;
            double sumforjun = 0;
            double sumforjul = 0;
            double sumforaug = 0;
            double sumforsep = 0;
            double sumforoct = 0;
            double sumfornov = 0;
            double sumfordec = 0;

            for (int i = 1; i < columns.Length; i++)
            {
                string column = columns[i];
                string[] splitcolumns = column.Split(',');
                double sale = Convert.ToDouble(splitcolumns[4]);
                string year = splitcolumns[9];
                if (splitcolumns[6].ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumfor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumfor2004 += sale;
                    }
                    else
                    {
                        sumfor2005 += sale;
                    }

                    int month = Convert.ToInt32(splitcolumns[8]);
                    if (month == 1)
                    {
                        sumforjan += sale;
                    }

                    else if (month == 2)
                    {
                        sumforfeb += sale;
                    }

                    else if (month == 3)
                    {
                        sumformar += sale;
                    }

                    else if (month == 4)
                    {
                        sumforapr += sale;
                    }

                    else if (month == 5)
                    {
                        sumformay += sale;
                    }

                    else if (month == 6)
                    {
                        sumforjun += sale;
                    }

                    else if (month == 7)
                    {
                        sumforjul += sale;
                    }

                    else if (month == 8)
                    {
                        sumforaug += sale;
                    }
                    else if (month == 9)
                    {
                        sumforsep += sale;
                    }
                    else if (month == 10)
                    {
                        sumforoct += sale;
                    }
                    else if (month == 11)
                    {
                        sumfornov += sale;
                    }

                    else
                    {
                        sumfordec += sale;
                    }






                    sum += sale;


                }



            }

            Console.WriteLine($"The sum of all sales in 2003 is {sumfor2003.ToString("C")}");
            Console.WriteLine($"The sum of all sales in 2004 is {sumfor2004.ToString("C")}");
            Console.WriteLine($"The sum of all sales in 2005 is {sumfor2005.ToString("C")}");
            Console.WriteLine($"The total sum of sales in January across all years is {sumforjan.ToString("C")}");
            Console.WriteLine($"The total sum of sales in February across all years is {sumforfeb.ToString("C")}");
            Console.WriteLine($"The total sum of sales in March across all years is {sumformar.ToString("C")}");
            Console.WriteLine($"The total sum of sales in April across all years is {sumforapr.ToString("C")}");
            Console.WriteLine($"The total sum of sales in May across all years is {sumformay.ToString("C")}");
            Console.WriteLine($"The total sum of sales in June across all years is {sumforjun.ToString("C")}");
            Console.WriteLine($"The total sum of sales in July across all years is {sumforjul.ToString("C")}");
            Console.WriteLine($"The total sum of sales in August across all years is {sumforaug.ToString("C")}");
            Console.WriteLine($"The total sum of sales in September across all years is {sumforsep.ToString("C")}");
            Console.WriteLine($"The total sum of sales in October across all years is {sumforoct.ToString("C")}");
            Console.WriteLine($"The total sum of sales in November across all years is {sumfornov.ToString("C")}");
            Console.WriteLine($"The total sum of sales in December across all years is {sumfordec.ToString("C")}");
           
            Console.ReadKey();


        }
    }
}
