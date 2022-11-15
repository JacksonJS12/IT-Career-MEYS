using System;

namespace P04.RectangleSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numA = decimal.Parse(Console.ReadLine());
            var numB = decimal.Parse(Console.ReadLine());

            var area = numA * numB;
            Console.WriteLine(area);
        }
    }
}
