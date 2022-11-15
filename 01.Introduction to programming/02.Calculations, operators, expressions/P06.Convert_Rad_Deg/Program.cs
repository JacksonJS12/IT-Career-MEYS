using System;

namespace P06.Convert_Rad_Deg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputInRadian = double.Parse(Console.ReadLine());

            var outputInDegrees = inputInRadian * 180 / Math.PI;
            Console.WriteLine(Math.Round(outputInDegrees));
        }
    }
}
