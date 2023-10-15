using Console_App_Restoran.Models;

namespace Console_App_Restoran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Restaurant menyu = new Restaurant();
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("============ Operations Menyu ============");
                Console.WriteLine("~1~ Add Food");
                Console.WriteLine("~2~ Add Drink");
                Console.WriteLine("~3~ Show all menyu");
                Console.WriteLine("~4~ Search by price in menyu");
                Console.WriteLine("~5~ Searc by alcohol percent in menyu");
                Console.WriteLine("~0~ Close program");
                Console.WriteLine("==========================================");
                Console.WriteLine(" ");

                Console.WriteLine("Select operation");

                string input;
                input= Console.ReadLine();

                Console.WriteLine("------------------------------------------");

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Insert name of food");
                        string foodName=Console.ReadLine();

                        Console.WriteLine("Insert price of food");
                        double foodPrice = Convert.ToDouble(Console.ReadLine());
                        //string price=Console.ReadLine();
                        //double foodPrice;
                        //double.TryParse(price, out foodPrice);

                        menyu.AddFood(foodName, foodPrice);

                        Console.WriteLine("Food added to menyu");
                        break;

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" ");

                    case "2":
                        Console.WriteLine("Insert name of drink");
                        string drinkName = Console.ReadLine();

                        Console.WriteLine("Insert price of drink");
                        double drinkPrice = double.Parse(Console.ReadLine());

                        Console.WriteLine("Insert alcohol percent of drink");
                        byte alcoholpercent= byte.Parse(Console.ReadLine());

                        menyu.AddDrink(drinkName, drinkPrice, alcoholpercent);

                        Console.WriteLine("Drink added to menyu");
                        break;

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" ");

                    case "3":
                        if(menyu!=null)
                        {
                            menyu.ShowAllMenyu();
                        }
                        else
                        {
                            Console.WriteLine("Please, first add to the menyu");
                            Console.WriteLine(" ");
                        }
                        break;

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" ");

                    case "4":
                        if (menyu != null)
                        {
                            Console.WriteLine("Insert min price value for search");
                            int minprice=int.Parse(Console.ReadLine());

                            Console.WriteLine("Insert max price value for search");
                            int maxprice=int.Parse(Console.ReadLine());

                            menyu.GetMenyuByPrice(minprice, maxprice);
                        }
                        else
                        {
                            Console.WriteLine("Please, first add to the menyu");
                            Console.WriteLine(" ");
                        }
                        break;

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" ");

                    case "5":
                        if (menyu != null)
                        {
                            Console.WriteLine("Insert alcohol percent for search");
                            byte searchpercent = byte.Parse(Console.ReadLine());

                            menyu.GetMenyuByAlcoholPercent(searchpercent);
                        }
                        else
                        {
                            Console.WriteLine("Please, first add to the menyu");
                            Console.WriteLine(" ");
                        }
                        break;

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine(" ");

                    case "0":
                        check=false;
                        Console.WriteLine("Bye-Bye :)");
                        break;
                }
            }
            while (check);
        }
    }
}