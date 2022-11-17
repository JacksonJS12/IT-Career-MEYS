using System;

namespace P25.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var colls = int.Parse(Console.ReadLine());

            bool flag = false;
            decimal price = 0;
            if (type == "Premiere")
            {
                price = 12m;
            }
            else if (type == "Normal")
            {
                price = 7.5m;
            }
            else if (type == "Discount")
            {
                price = 5m;
            }

            /*
            This part is not part of the task
            but in the real world it should return an error
            */
            else
            {
                flag = true;
                Console.WriteLine("Wrong input data!"); 
            }

            if (!flag)
            {
                var res = rows * colls * price;

                Console.WriteLine($"{res:f2} leva");
            }
        }
    }
}
