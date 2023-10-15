using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_App_Restoran.Models
{
    internal class Restaurant
    {
        Food[] Foods=new Food[0];
        Drink[] Drinks=new Drink[0];

        public Restaurant()
        {
        }
        public void AddFood(string foodname, double foodprice)
        {
            Food food = new Food(foodname, foodprice);
            Array.Resize(ref Foods, Foods.Length + 1);
            Foods[Foods.Length - 1] = food;
        }

        public void AddDrink(string drinkname, double drinkprice, byte alcoholpercent)
        {
            Drink drink=new Drink(drinkname, drinkprice, alcoholpercent);
            Array.Resize(ref Drinks, Drinks.Length + 1);
            Drinks[Drinks.Length - 1] = drink;
        }

        public void ShowAllMenyu()
        {
            Console.WriteLine("====== Foods ======");
            foreach(Food food in Foods)
            {
                Console.WriteLine($"Name: {food.Name}, Price: {food.Price}");
            }

            Console.WriteLine("====== Drinks ======");
            foreach (Drink drink in Drinks)
            {
                Console.WriteLine($"Name: {drink.Name}, Alcohol percent: {drink.AlcoholPercent}, Price: {drink.Price}");
            }
        }

        public void GetMenyuByPrice(int minprice, int maxprice)
        {
            Console.WriteLine("====== Foods ======");
            foreach (Food food in Foods)
            {
                if(food.Price >= minprice && food.Price <= maxprice)
                {
                    Console.WriteLine($"Name: {food.Name}, Price: {food.Price}");
                }
            }

            Console.WriteLine("====== Drinks ======");
            foreach (Drink drink in Drinks)
            {
                if (drink.Price >= minprice && drink.Price <= maxprice)
                {
                    Console.WriteLine($"Name: {drink.Name}, Price: {drink.Price}");
                }
            }
        }

        public void GetMenyuByAlcoholPercent(byte query)
        {
            if(query > 0 && query <= 100)
            {
                foreach(Drink drink in Drinks)
                {
                    if(drink.AlcoholPercent >= query)
                    {
                        Console.WriteLine($"Name: {drink.Name}, Price: {drink.Price}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please, insert correct alcohol percent");
            }
        }
    }
}
