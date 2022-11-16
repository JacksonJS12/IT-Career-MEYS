using System;

namespace P07.Add15ToTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 15 > 59)
            {
                minutes += 15 - 60;
                if (hours + 1 > 23)
                {
                    hours = 0;
                }
                else
                {
                    hours += 1;
                }
            }
            else
            {
                minutes += 15;
            }

            var result = "";

            if (minutes < 10)
            {
                result = $"{hours}:0{minutes}";
            }
            else
            {
                result = $"{hours}:{minutes}";
            }

            Console.WriteLine(result);
        }
    }
}
