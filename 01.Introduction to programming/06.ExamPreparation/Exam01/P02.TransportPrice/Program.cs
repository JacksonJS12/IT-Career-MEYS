using System;

namespace P02.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var dayTime = Console.ReadLine();

            var transportType = "train";
            if (km >= 100)
            {
                //train
                transportType = "train";
            }
            else if (km >= 20)
            {
                //bus
                transportType = "bus";
            }
            else
            {
                transportType = "taxi";
            }

            double taxe = Taxe(km, dayTime, transportType);
            Console.WriteLine(Math.Round(taxe, 2));
        }

        static double Taxe(int km, string dayTime, string transportType)
        {
            double taxe = 0;
            if (transportType == "taxi")
            {
                if (dayTime == "day")
                {
                    taxe = 0.7 + (km * 0.79);
                }
                else if (dayTime == "night")
                {
                    taxe = 0.7 + (km * 0.9);
                }
               
            }
            else if (transportType == "bus")
            {
                taxe = km * 0.09;
            }
            else if (transportType == "train")
            {
                taxe = km * 0.06;
            }
            return taxe;
        }
    }
}
