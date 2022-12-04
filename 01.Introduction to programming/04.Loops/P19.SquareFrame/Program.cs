using System;

namespace P19.SquareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var res = string.Empty;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == 0 || col == n - 1)
                    {
                        if (row == 0 || row == n - 1)
                        {
                            res += $"+ ";
                        }
                        else if (row > 0 || row < n - 1)
                        {
                            res += $"| ";
                        }
                    }
                    else
                    {
                        res += $"- ";
                    }
                }
                res += Environment.NewLine;
            }
            Console.WriteLine(res);
        }
    }
}
