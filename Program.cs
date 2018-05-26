using System;

namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        static void PrintTriangle(int n)
        {
            for (int j = 1; j <= n; j++)
            {
                PrintLine(1, j);
            }

            for (int k = n - 1; k >= 1; k--)
            {
                PrintLine(1, k);
            }


        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
