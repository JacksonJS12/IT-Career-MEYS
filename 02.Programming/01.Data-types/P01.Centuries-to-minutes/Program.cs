using System;
namespace P01.Centuries_to_minutes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte c = byte.Parse(Console.ReadLine());
            uint y = (uint)(100U * c);
            uint d = (uint)(y * 365.2422);
            ulong h = 24UL * d;
            ulong m = 60UL * h;
            ulong s = 60UL * m;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                               c, y, d, h, m);
        }
    }
}