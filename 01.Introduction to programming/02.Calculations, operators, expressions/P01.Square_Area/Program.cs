using System;

namespace P01.Square_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Area = ");
            Console.WriteLine(area);
        }
    }
}
