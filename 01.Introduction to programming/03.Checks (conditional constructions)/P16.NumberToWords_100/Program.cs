using System;

namespace P16.NumberToWords_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputNum = int.Parse(Console.ReadLine());
            string result = string.Empty;

            if (inputNum < 10 &&
                inputNum >= 0)
            {
                result += From1To9(inputNum);
            }
            else if (inputNum < 20)
            {
                result = From10To19(inputNum);
            }
            else if (inputNum < 100)
            {
                int firstDigit = inputNum / 10;
                int secondDigit = inputNum % 10;

                result += From10To90(firstDigit) +
                          " " +
                          From1To9(secondDigit);

                if (secondDigit == 0)
                {
                    result = From10To90(firstDigit);
                }
            }
            else if (inputNum == 100)
            {
                result = "one hundred";
            }
            else
            {
                result = "too big number!";
            }

            Console.WriteLine(result);
        }

        private static string From1To9(int inputNum)
        {
            var result = string.Empty;
            switch (inputNum)
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }
        private static string From10To19(int inputNum)
        {
            var result = string.Empty;
            switch (inputNum)
            {
                case 10:
                    result = "ten";
                    break;
                case 11:
                    result = "eleven";
                    break;
                case 12:
                    result = "twelve";
                    break;
                case 13:
                    result = "thirteen";
                    break;
                case 14:
                    result = "fourteen";
                    break;
                case 15:
                    result = "fifteen";
                    break;
                case 16:
                    result = "sixteen";
                    break;
                case 17:
                    result = "seventeen";
                    break;
                case 18:
                    result = "eighteen";
                    break;
                case 19:
                    result = "nineteen";
                    break;
            }

            return result;
        }
        private static string From10To90(int inputNum)
        {
            var result = string.Empty;
            switch (inputNum)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "forty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }

            return result;
        }
    }
}

