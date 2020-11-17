using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Toys
{
    class Toy
    {
        public string Manufacturer;
        public string Name;
        public double Price;
        private string Notes; 

        public Toy()

        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = ""; 

        }

        public Toy(string Manufacturer, string Name, double Price, string Notes)
        {
            this.Manufacturer = Manufacturer;
            this.Name = Name;
            this.Price = Price;
            this.Notes = Notes; 
        }
    
      public string GetAisle()
        {


            
            char firstletter = Manufacturer[0];
            string hi = firstletter.ToString();
            string upper = hi.ToUpper(); 
           
            Random rnd = new Random();
            int number = rnd.Next(1, 25);

            return upper + number;
            


        }
    
    
    
    }
}
