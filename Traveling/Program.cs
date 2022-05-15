using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = null;

            while ((destination = Console.ReadLine()) != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double savings = 0;
                double totalMoney = 0;

                while (totalMoney < minBudget)
                {
                    savings = double.Parse(Console.ReadLine());
                    totalMoney += savings;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
