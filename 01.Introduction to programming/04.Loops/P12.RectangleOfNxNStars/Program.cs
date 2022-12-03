using System;

namespace P12.RectangleOfNxNStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
