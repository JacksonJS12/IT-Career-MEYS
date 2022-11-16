using System;
using System.Data.SqlTypes;

namespace P14.SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());

            if(input <= 10)
            {
                Console.WriteLine("slow");
            }
            else if(input <= 50)
            {
                Console.WriteLine("average");
            }
            else if(input <= 150)
            {
                Console.WriteLine("fast");
            }
            else if(input <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
