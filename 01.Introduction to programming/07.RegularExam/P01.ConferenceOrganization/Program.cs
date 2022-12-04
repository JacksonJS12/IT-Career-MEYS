using System;

namespace P01.ConferenceOrganization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rent = int.Parse(Console.ReadLine());
            double food = rent * 2;
            double drinks = food - (food * 0.15);
            double gifts = 0.1428571428571429 * (drinks + food);

            var total = rent + food + drinks + gifts;
            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
