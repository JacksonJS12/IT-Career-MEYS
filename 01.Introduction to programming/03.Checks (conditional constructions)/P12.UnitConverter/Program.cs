using System;

namespace P12.UnitConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double mToMm = 1000;
            const double mToCm = 100;
            const double mToMi = 0.000621371192;
            const double mToIn = 39.3700787;
            const double mToKm = 0.001;
            const double mToFt = 3.2808399;
            const double mToYd = 1.0936133;

            var input = double.Parse(Console.ReadLine());
            var inputUnit = Console.ReadLine();
            var outputUnit = Console.ReadLine();

            switch (inputUnit)
            {
                case "mm":
                    input /= mToMm;
                    break;
                case "cm":
                    input /= mToCm;
                    break;
                case "mi":
                    input /= mToMi;
                    break;
                case "in":
                    input /= mToIn;
                    break;
                case "km":
                    input /= mToKm;
                    break;
                case "ft":
                    input /= mToFt;
                    break;
                case "yd":
                    input /= mToYd;
                    break;
            }

            var unit = "m";
            switch (outputUnit)
            {
                case "mm":
                    input *= mToMm;
                    unit = "mm";
                    break;
                case "cm":
                    input *= mToCm;
                    unit = "cm";
                    break;
                case "mi":
                    input *= mToMi;
                    unit = "mi";
                    break;
                case "in":
                    input *= mToIn;
                    unit = "in";
                    break;
                case "km":
                    input *= mToKm;
                    unit = "km";
                    break;
                case "ft":
                    input *= mToFt;
                    unit = "ft";
                    break;
                case "yd":
                    input *= mToYd;
                    unit = "yd";
                    break;
            }

            Console.WriteLine($"{input} {unit}");
        }
    }
}
