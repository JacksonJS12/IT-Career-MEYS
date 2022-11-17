using System;

namespace P05.SquareOfNStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNum; i++)
            {
                if(i == 0 ||
                    i == inputNum - 1)
                {
                    for (int k = 0; k < inputNum; k++)
                    {
                        Console.Write('*');
                    }
                }
                else
                {
                    for (int k = 0; k < inputNum; k++)
                    {
                        if(k == 0 ||
                            k == inputNum - 1)
                        {
                            Console.Write('*');
                            continue;
                        }
                        Console.Write(' ');

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
