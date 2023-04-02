using System;

namespace P04.ChristmasGifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var childrenCount = int.Parse(Console.ReadLine());

            int legoCounter = 0;
            int monopolyCounter = 0;
            int puzzlesCounter = 0;
            int robotsCounter = 0;
            for (int i = 0; i < childrenCount; i++)
            {
                var gift = Console.ReadLine();
                switch (gift)
                {
                    case "lego":
                        legoCounter++;
                        break;
                    case "monopoly":
                        monopolyCounter++;
                        break;
                    case "puzzle":
                        puzzlesCounter++;
                        break;
                    case "robot":
                        robotsCounter++;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"Lego: {legoCounter}");
            Console.WriteLine($"Monopoly: {monopolyCounter}");
            Console.WriteLine($"Puzzles: {puzzlesCounter}");
            Console.WriteLine($"Robots: {robotsCounter}");
        }
    }
}
