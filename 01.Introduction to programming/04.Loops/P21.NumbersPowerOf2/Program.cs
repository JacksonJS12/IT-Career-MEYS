using System;

namespace P16.NumbersPowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var power = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(power);
                power *= 2;
            }
        }
    }
}
s