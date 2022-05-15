using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int m = 1; m <= 10; m++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    int result = m * n;
                    Console.WriteLine($"{m} * {n} = {result}");
                }
            }
        }
    }
}
