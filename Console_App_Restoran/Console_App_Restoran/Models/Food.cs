﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Restoran.Models
{
    internal class Food
    {
        public string ?Name { get; set; }
        public double Price { get; set; }

        public Food(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
