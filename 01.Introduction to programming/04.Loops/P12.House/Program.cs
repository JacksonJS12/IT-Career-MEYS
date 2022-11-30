using System;

namespace P12.House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int roofRows = (n + 1) / 2;

                for (int i = 0; i < roofRows; i++)
                    Roof(roofRows - (i + 1), n);

                int remainingRows = n - roofRows;
                for (int i = 0; i < remainingRows; i++)
                    Body(n);
            }

            static void Roof(int underscoresCount, int n)
            {
                for (int i = 0; i < underscoresCount; i++) 
                    Console.Write('_');
                for (int i = underscoresCount; i < n / 2; i++) 
                    Console.Write('*');

                if (n % 2 != 0) Console.Write('*');

                for (int i = underscoresCount; i < n / 2; i++) 
                    Console.Write('*');
                for (int i = 0; i < underscoresCount; i++) 
                    Console.Write('_');

                Console.WriteLine();
            }

            static void Body(int n)
            {
                Console.Write('|');
                for (int i = 0; i < n - 2; i++) 
                    Console.Write('*');
                Console.Write('|');

                Console.WriteLine();
            }
        }
    }
}
