using System;

namespace P05.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long largestNum = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long currentNum = int.Parse(Console.ReadLine());
                largestNum = currentNum > largestNum ? currentNum : largestNum;
            }
            Console.WriteLine(largestNum);
        }
    }
}
