using System;

namespace P08.ThreeEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());

            var result = "no";
            if(num1 == num2)
            {
                if(num1 == num3)
                {
                    result = "yes";
                }
            }

            Console.WriteLine(result);
        }
    }
}
