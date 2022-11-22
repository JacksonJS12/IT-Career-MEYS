using System;

namespace P08.EvenOddSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    continue;
                }
                oddSum += num;
            }

            var res = evenSum == oddSum ? $"Yes Sum = {evenSum}" : $"No Diff = {Math.Abs(evenSum - oddSum)}";
            Console.WriteLine(res);

        }
    }
}
