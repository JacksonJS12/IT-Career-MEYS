using System;

namespace P21.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());

            if (!(input >= 100 && input <= 200 || input == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
