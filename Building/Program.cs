using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            for (int f = floor; f >= 1; f--)
            {
                for (int n = 0; n < number; n++)
                {
                    if (f == floor)
                    {
                        Console.Write($"L{f}{n} ");
                    }
                    else if (f % 2 == 0)
                    {
                    Console.Write($"O{f}{n} ");
                    }
                    else if (f % 2 != 0)
                    {
                        Console.Write($"A{f}{n} ");
                    }
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
