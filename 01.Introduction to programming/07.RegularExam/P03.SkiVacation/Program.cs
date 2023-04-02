using System;

namespace P03.SkiVacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var destinationsAndPrices = new Dictionary<string, Dictionary<string, double>>()
            {
                { "double room", new Dictionary<string, double>()
                    {
                        {"Colorado", 38} ,
                        {"Alps", 35},
                        {"Andie", 39}
                    }
                },

                { "apartment", new Dictionary<string, double>()
                    {
                        {"Colorado", 45} ,
                        {"Alps", 42},
                        {"Andie", 49}
                    }
                }
            };

            var nights = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine();
            var roomType = Console.ReadLine();

            foreach (var currRoomType in destinationsAndPrices.Keys)
            {
                if (currRoomType == roomType)
                {
                    foreach (var currDestination in destinationsAndPrices[currRoomType])
                    {
                        if (currDestination.Key == destination)
                        {
                            Console.WriteLine($"They have to spend {(nights * currDestination.Value):f2} leva.");
                            break;
                        }
                    }
                }
            }
        }
    }
}
