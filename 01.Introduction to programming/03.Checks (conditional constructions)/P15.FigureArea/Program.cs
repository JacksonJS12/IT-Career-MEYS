using System;
using System.Diagnostics;
using System.Drawing;

namespace P15.FigureArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var sideA = double.Parse(Console.ReadLine());

            double sideB = 0;
            double area = 0;

            if (type == "square")
            {
                area = sideA * sideA;
            }
            else if (type == "rectangle")
            {
                sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (type == "circle")
            {
                area = sideA * sideA * Math.PI;
            }
            else if (type == "triangle")
            {
                sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB * 0.5;
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
