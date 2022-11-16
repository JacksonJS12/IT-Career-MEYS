using System;

namespace P06.SameWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();

            var result = firstWord.ToLower() == secondWord.ToLower() ? "yes" : "no";

            Console.WriteLine(result);
        }
    }
}
