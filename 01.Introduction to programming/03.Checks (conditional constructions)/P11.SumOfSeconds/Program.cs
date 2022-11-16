using System;

namespace P11.SumOfSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstFinisher = int.Parse(Console.ReadLine());
            int secondFinisher = int.Parse(Console.ReadLine());
            int thirdFinisher = int.Parse(Console.ReadLine());

            int total = firstFinisher + secondFinisher + thirdFinisher;
            int minutes = 0;
            int seconds = 0;
            if (total < 59)
            {
                seconds = total;
            }
            else
            {
                minutes = total / 60;
                seconds = total % 60;
            }
            var result = "";

            if (seconds < 10)
            {
                result = $"{minutes}:0{seconds}";
            }
            else
            {
                result = $"{minutes}:{seconds}";
            }

            Console.WriteLine(result);
        }
    }
}
