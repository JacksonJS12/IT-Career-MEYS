using System;

namespace P03.Odd_Or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputNum = double.Parse(Console.ReadLine());

            string evenOrOdd = inputNum % 2 == 0 ? "even" : "odd";

            Console.WriteLine(evenOrOdd);
        }
    }
}
