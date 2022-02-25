using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {           
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                int numTwo = int.Parse(Console.ReadLine());
                sum += numTwo;
            }
            Console.WriteLine($"{(sum/num):f2}");
        }
    }
}
