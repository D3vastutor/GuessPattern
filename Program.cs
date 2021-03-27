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

            bool validator = InputValidation(n);
            if (validator)
                GeneratePattern(n);
            else
                Console.WriteLine("That's not accepted number!");

            Console.ReadLine();
        }

        private static bool InputValidation(int n)
        {
            if (n > 20 || n < -5)
            {
                return false;
            }
            return true;
        }

        private static void GeneratePattern(int num)
        {
            int x, y, a, b;
            #region simple version
            //for (x = 1; x <= num; x++)
            //{
            //    // Write (num - x) spaces at once
            //    Console.Write(new string(' ', num - x));

            //    // Write 'x' count of "*", joined with a " "
            //    Console.WriteLine(string.Join(" ", Enumerable.Repeat("*", x)));
            //}
            //for (y = num - 1; y >= 1; y--)
            //{
            //    // Write (num - y) spaces at once
            //    Console.Write(new string(' ', num - y));

            //    // Write 'y' count of "*", joined with a " "
            //    Console.WriteLine(string.Join(" ", Enumerable.Repeat("*", y)));
            //} 
            #endregion


            #region detail version
            for (x = 1; x <= num; x++)
            {
                for (a = x; a < num; a++)
                {
                    Console.Write(" ");
                }

                for (b = x; b >= 1; b--)
                {
                    Console.Write("*");
                    if (b <= x) Console.Write(" ");
                }

                Console.WriteLine();
            }
            for (y = num - 1; y >= 1; y--)
            {
                for (a = num; a > y; a--)
                {
                    Console.Write(" ");
                }

                for (b = 1; b <= y; b++)
                {
                    Console.Write("*");
                    if (b < y) Console.Write(" ");
                }

                Console.WriteLine();
            } 
            #endregion
        }
    }
}
