﻿using System;

namespace P01.Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if(grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
