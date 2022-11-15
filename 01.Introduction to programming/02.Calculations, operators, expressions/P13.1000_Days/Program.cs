using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace P13._1000_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime dateOfBirth = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime output = dateOfBirth.AddDays(999);
           
            Console.WriteLine(output.ToString("dd-MM-yyyy"));
        }
    }
}
