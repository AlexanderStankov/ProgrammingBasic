using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int n = x; n <= y; n++)
            {
                for (int m = x; m <= y; m++)
                {
                    counter++;
                    if (n + m == magic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({n} + {m} = {magic})");
                        return; ;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magic}");
        }
    }
}
