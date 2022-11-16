using System;

namespace P05.GuessPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string password = "s3cr3t!P@ssw0rd";

            var input = Console.ReadLine();

            var result = input == password ? "Welcome" : "Wrong password!";

            Console.WriteLine(result);
        }
    }
}
