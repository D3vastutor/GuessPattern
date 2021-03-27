using System;

namespace GuessPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //GenerateUpper(n);
            //GenerateBottom(n);
            GeneratePattern(n);

            Console.ReadLine();
        }

        private static void GeneratePattern(int n)
        {
            int x, y, z;
            for (x = n; x >= 1; x--)
            {
                for (y = 1; y < x; y++)
                {
                    Console.Write(" ");
                }
                for (z = n; z >= x; z--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();

                if (z == 0)
                {
                    GenerateBottom(n);
                }
            }
        }

        private static void GenerateUpper(int n)
        {
            int x , y, z;
            for (x = n; x >= 1; x--)
            {
                for (y = 1; y < x; y++)
                {
                    Console.Write(" ");
                }
                for (z = n; z >= x; z--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }

        private static void GenerateBottom(int n)
        {
            int x , y;
            for (x = n; x >= 0; --x)
            {
                if (x != 0)
                {
                    string spasi = new String(' ', n);
                    Console.Write(spasi);
                }
                for (y = 1; y <= x; y++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }
}
