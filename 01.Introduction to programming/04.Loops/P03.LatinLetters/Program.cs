using System;

namespace P03.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //in decimal numeral in ASCII table 'a' is 97 and 'z' is 122
            Console.Write("Latin alphabet: ");
            for (int i = 97; i <= 122; i++)
            {
                char ch = (char)i;
                Console.Write(ch + " ");
            }
        }
    }
}
