using System;

namespace P11.SunGlasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Row(n);
            for (int r = 0; r < n - 2; r++)
            {
                if (r + 1 == (n - 1) / 2) MiddleRow(n, '|');
                else MiddleRow(n, ' ');
            }
            Row(n);
        }

        static void Row(int n)
        {
            for (int i = 0; i < 2 * n; i++) 
                Console.Write('*');
            for (int i = 0; i < n; i++) 
                Console.Write(' ');
            for (int i = 0; i < 2 * n; i++) 
                Console.Write('*');

            Console.WriteLine();
        }

        static void MiddleRow(int n, char symbol)
        {
            Console.Write('*');
            for (int i = 0; i < n * 2 - 2; i++) 
                Console.Write('/');
            Console.Write('*');

            for (int i = 0; i < n; i++) 
                Console.Write(symbol);

            Console.Write('*');
            for (int i = 0; i < n * 2 - 2; i++) 
                Console.Write('/');
            Console.Write('*');

            Console.WriteLine();
        }
    }
}
