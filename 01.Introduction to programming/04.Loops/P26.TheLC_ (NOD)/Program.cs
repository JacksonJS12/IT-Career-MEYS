using System;

namespace P26.TheLC___NOD_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            while (num1 != 0
                && num2 != 0)
            {
                if (num1 > num2)
                    num1 %= num2;
                else
                    num2 %= num1;
            }

            int lcd = Math.Max(num1, num2);
            Console.WriteLine(lcd);
        }
    }
}
