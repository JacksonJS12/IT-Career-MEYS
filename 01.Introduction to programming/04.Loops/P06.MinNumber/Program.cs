using System;

namespace P06.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long smallestNum = long.MaxValue;
            for (int i = 0; i < n; i++)
            {
                long currentNum = int.Parse(Console.ReadLine());
                smallestNum = currentNum < smallestNum ? currentNum : smallestNum;
            }
            Console.WriteLine(smallestNum);
        }
    }
}
