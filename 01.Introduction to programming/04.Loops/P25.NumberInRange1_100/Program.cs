using System;

namespace P25.NumberInRange1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number in the range [1...100]: ");
                int num = int.Parse(Console.ReadLine());
                if (num <= 100 &&
                    num >= 1)
                {
                    Console.WriteLine("The number is: " + num);
                    break;
                }
                Console.WriteLine("Invalid number!");
            }

        }
    }
}
