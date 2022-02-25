using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double product = 0;
            int sumMoneyExpected = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double cart = 0;
            double cash = 0;
            int cashCount = 0;
            int productsCount = 0;
            int cartCount = 0;
            double sum = 0;
            while (input != "End")
            {
                productsCount++;
                product = int.Parse(input);
                if (productsCount % 2 != 0)
                {
                    if (product > 100)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        cash += product;
                        cashCount++;
                    }
                }
                else
                {
                    if (product < 10)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        cart += product;
                        cartCount++;
                    }
                }
                sum = cart + cash;
                if (sum >= sumMoneyExpected)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            sum = cash + cart;
            double sumCash = cash / cashCount;
            double cartCash = cart / cartCount;
            if (sum >= sumMoneyExpected)
            {
                Console.WriteLine($"Average CS: {sumCash:f2}");
                Console.WriteLine($"Average CC: {cartCash:f2}");
            }
            else
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
        }
    }
}
