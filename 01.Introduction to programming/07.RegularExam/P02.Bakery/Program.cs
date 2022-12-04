using System;

namespace P02.Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodOnePrice = double.Parse(Console.ReadLine());

            double foodTwoPrice = foodOnePrice + (foodOnePrice * 0.2);
            double foodThreePrice = foodTwoPrice - (foodTwoPrice * 0.4);
            double foodFourPrice = foodThreePrice + 1.2;

            int foodOneQuantity = int.Parse(Console.ReadLine());
            int foodTwoQuantity = int.Parse(Console.ReadLine());
            int foodThreeQuantity = int.Parse(Console.ReadLine());
            int foodFourQuantity = int.Parse(Console.ReadLine());

            double budget = double.Parse(Console.ReadLine());

            double foodOneTotal = (foodOnePrice * foodOneQuantity);
            double foodTwoTotal = (foodTwoPrice * foodTwoQuantity);
            double foodThreeTotal = (foodThreePrice * foodThreeQuantity);
            double foodFourTotal = (foodFourPrice * foodFourQuantity);

            double total = foodOneTotal + foodTwoTotal + foodThreeTotal + foodFourTotal;

            var res = budget >= total ? $"Yes! {(budget - total):f2} leva left." : $"No! {(total - budget):f2} leva needed.";
            Console.WriteLine(res);
        }
    }
}
