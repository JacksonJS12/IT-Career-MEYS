using System;

namespace P05.Convert_C_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputInC = double.Parse(Console.ReadLine());

            var degreesCelsiusToFahrenheit = inputInC * 1.8 + 32;
            Console.WriteLine(degreesCelsiusToFahrenheit);
        }
    }
}
