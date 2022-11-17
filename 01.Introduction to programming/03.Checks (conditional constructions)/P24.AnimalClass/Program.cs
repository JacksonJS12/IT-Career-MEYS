using System;

namespace P24.AnimalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine();

            var res = string.Empty;
            if (animal == "dog")
            {
                res = "mammal";
            }
            else if (animal == "crocodile" ||
                     animal == "tortoise" ||
                     animal == "snake")
            {
                res = "reptile";
            }
            else
            {
                res = "unknown";
            }

            Console.WriteLine(res);
        }
    }
}
