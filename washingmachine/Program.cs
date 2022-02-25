using System;

namespace washingmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double platesAndPots=0 ;
            string text = Console.ReadLine();
            int washingBottles = int.Parse(Console.ReadLine()) * 750;
            double pots = 0;
            double dishes = 0;
            while(text != "End")
            {                    
                platesAndPots += double.Parse(text);
                text = Console.ReadLine();
            }
        }
    }
}
