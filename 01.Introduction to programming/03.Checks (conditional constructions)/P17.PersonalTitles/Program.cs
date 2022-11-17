using System;

namespace P17.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());

            if (gender == 'm')
            {
                if(age > 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if(gender == 'f')
            {
                if (age > 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
