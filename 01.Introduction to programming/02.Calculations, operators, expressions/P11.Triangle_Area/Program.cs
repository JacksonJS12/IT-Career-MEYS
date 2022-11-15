using System;

namespace P11.Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sideA = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = sideA * height / 2;

            Console.WriteLine($"Triangle area = {Math.Round(area, 2)}");
        }
    }
}
