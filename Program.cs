using System;
using System.Linq;

namespace GuessPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            GeneratePattern(n);

            Console.ReadLine();
        }

        private static void GeneratePattern(int num)
        {
            int x, y;
            for (x = 1; x <= num; x++)
            {
                // Write (5 - i) spaces at once
                Console.Write(new string(' ', num - x));

                // Write 'i' count of "*", joined with a "_"
                Console.WriteLine(string.Join(" ", Enumerable.Repeat("*", x)));
            }
            for (y = num; y >= 1; y--)
            {
                // Write (5 - i) spaces at once
                Console.Write(new string(' ', num - y));

                // Write 'i' count of "*", joined with a "_"
                Console.WriteLine(string.Join(" ", Enumerable.Repeat("*", y)));
            }

            Console.ReadLine();
        }
    }
}
