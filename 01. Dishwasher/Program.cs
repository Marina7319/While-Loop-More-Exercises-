using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int washingBottles = int.Parse(Console.ReadLine()) * 750;
            int platesAndPots = 0;
            double pots = 0;
            double dishes = 0;
            string text = Console.ReadLine();
            int dishWashingMachines = 0;
            while (text != "End")
            {
                platesAndPots = int.Parse(text);
                dishWashingMachines++;
                if (dishWashingMachines % 3 != 0)
                {
                    dishes += platesAndPots;
                }
                if (dishWashingMachines % 3 == 0)
                {
                    pots += platesAndPots;
                }
                double washingMachinePreparatForWahingMachine = dishes * 5 + pots * 15;
                if (washingMachinePreparatForWahingMachine >= washingBottles)
                {
                    break;
                }

                text = Console.ReadLine();
            }
            double washingMachinePreparat = dishes*5 + pots*15;
            if (washingMachinePreparat <= washingBottles)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {washingBottles - washingMachinePreparat} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {washingMachinePreparat - washingBottles} ml. more necessary!");
            }
        }
    }
}
