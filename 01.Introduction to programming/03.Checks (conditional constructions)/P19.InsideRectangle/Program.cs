﻿using System;

namespace P19.FruitVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine()); 
            var y1 = double.Parse(Console.ReadLine()); 
            var x2 = double.Parse(Console.ReadLine()); 
            var y2 = double.Parse(Console.ReadLine());

            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var result = x >= x1 && y >= y1 && 
                         x <= x2 && y <= y2 ? 
                         "Inside" : "Outside";

            Console.WriteLine(result);
        }
    }
}
