using System;

namespace P09.Area_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;

            Console.WriteLine($"Area = {Math.Round(area, 2)}");
            Console.WriteLine($"Perimeter = {Math.Round(perimeter, 2)}");
        }
    }
}
