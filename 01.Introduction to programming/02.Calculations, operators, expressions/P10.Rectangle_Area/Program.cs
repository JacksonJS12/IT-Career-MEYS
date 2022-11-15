using System;

namespace P10.Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            // if x1 > x2 -> x1 - x2
            // otherwise x2 - x1
            var sideA = x1 > x2 ? x1 - x2 : x2 - x1;
            // using the same logic about y parameters
            var sideB = y1 > y2 ? y1 - y2 : y2 - y1;

            var area = sideA * sideB;
            var perimeter = (sideA + sideB) * 2;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
