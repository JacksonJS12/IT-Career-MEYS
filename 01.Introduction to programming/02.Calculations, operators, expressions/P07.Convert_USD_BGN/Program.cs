using System;

namespace P07.Convert_USD_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double usd = 1.79549;
            var inputInUSD = double.Parse(Console.ReadLine());

            var outputInBGN = inputInUSD * usd;
            Console.WriteLine($"{outputInBGN:f2} BGN");
        }
    }
}
