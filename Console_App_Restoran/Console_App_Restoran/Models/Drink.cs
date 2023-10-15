using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Restoran.Models
{
    internal class Drink
    {
        public string Name { get; set; }
        public double Price { get; set; }
        private byte _alcoholPercent;
        public byte AlcoholPercent
        { 
            get
            {
                return _alcoholPercent;
            }
            set
            {
                if(value>=0 && value<=100)
                {
                    _alcoholPercent = value;
                }
            }
        }

        public Drink(string name, double price, byte alcoholpercent)
        {
            Name = name;
            Price = price;
            AlcoholPercent = alcoholpercent;
        }
    }
}
