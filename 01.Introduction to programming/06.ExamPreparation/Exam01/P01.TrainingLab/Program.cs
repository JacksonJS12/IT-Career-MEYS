using System;

namespace P01.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double rows = Math.Truncate((width * 100 - 100) / 70);
            double cols = Math.Truncate(height * 100 / 120);

            double ans = rows * cols - 3;
            Console.WriteLine(ans);
        }
    }
}
