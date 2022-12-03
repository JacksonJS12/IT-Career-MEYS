using System;

namespace P27.Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var lastNumValue = 1;
            for (int i = 1; i <= n; i++)
            {
                lastNumValue *= i;
            }
            Console.WriteLine(lastNumValue);
        }
    }
}
