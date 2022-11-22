using System;

namespace P07.LeftRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftPart = 0;
            var rightPart = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                leftPart += num;
            }

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                rightPart += num;
            }
            var diff = Math.Abs(leftPart - rightPart);
            if (diff == 0)
            {
                Console.WriteLine($"yes, sum = {leftPart}");
            }
            else
            {
                Console.WriteLine($"no, diff = {diff}");
            }
        }
    }
}
