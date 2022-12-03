using System;

namespace P24.OrderOf2kPlus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n + 1; i *= 2)
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }
}
