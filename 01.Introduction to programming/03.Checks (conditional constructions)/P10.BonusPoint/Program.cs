﻿using System;

namespace P10.BonusPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var points = double.Parse(Console.ReadLine());

            double bonusPoints = 0;
            if (points <= 100)
            {
                bonusPoints += 5;
            }
            else if(points > 100 && points < 1000)
            {
                bonusPoints = points * 0.2;
            }
            if (points > 1000)
            {
                bonusPoints += points * 0.1;
            }

            if(points % 2 == 0)
            {
                bonusPoints += 1;
            }

            if(points % 10 == 5)
            {
                bonusPoints += 2;
            }


            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}