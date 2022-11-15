using System;

namespace P03.TriangleOf55Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
