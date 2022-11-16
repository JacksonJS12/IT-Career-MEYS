using System;

namespace P04.Max_Of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            int biggestNum = firstNum > secondNum ? firstNum : secondNum;

            Console.WriteLine(biggestNum);
        }
    }
}
