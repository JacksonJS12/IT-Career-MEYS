using System;

namespace P20.FruitVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fruits = new string[]
            {
                 "banana", "apple", "kiwi", "cherry", "lemon", "grapes"
            };

            var vegetables = new string[]
            {
                 "tomato", "cucumber", "pepper", "carrot"
            };

            var input = Console.ReadLine();

            var flag = false;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (input == fruits[i])
                {
                    flag = true;
                    Console.WriteLine("fruit");
                }
                if (i < vegetables.Length)
                {
                    if (input == vegetables[i])
                    {
                        flag = true;
                        Console.WriteLine("vegetable");
                    }
                }
            }

            if (!flag)
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
