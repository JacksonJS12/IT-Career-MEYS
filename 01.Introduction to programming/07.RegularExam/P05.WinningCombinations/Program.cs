using System;
using System.Collections.Generic;

namespace P05.WinningCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var combinationsVariations = new List<string>();
            var winningCombinations = new List<string>();
            CombinationsVariations(combinationsVariations);

            for (int i = 0; i < combinationsVariations.Count; i++)
            {
                string combToCheck = combinationsVariations[i];
                char lastDigit = '0';
                bool firstConditions = false;
                bool secondConditions = false;
                bool tirthConditions = false;
                bool fourthConditions = false;
                for (int k = 0; k < combToCheck.Length; k++)
                {
                    char currDigit = combToCheck[k];
                    if (k == 0)
                    {
                        lastDigit = currDigit;
                        continue;
                    }

                    int lastTwoDigitSum = (int)(currDigit - '0') + (int)(lastDigit - '0');
                    if (k == 1 && lastTwoDigitSum == n)
                    {
                        firstConditions = true;
                    }
                    if (k == 2 && (int)(currDigit - '0') % 2 == 0)
                    {
                        secondConditions = true;
                    }
                    if (k == 3 && ((int)(currDigit - '0') == 0 || (int)(currDigit - '0') == 9))
                    {
                        tirthConditions = true;
                    }
                    if (k == 4 && ((int)(currDigit - '0') == 3 || (int)(currDigit - '0') == 6))
                    {
                        fourthConditions = true;
                    }

                    lastDigit = currDigit;
                }
                if (firstConditions && secondConditions && tirthConditions && fourthConditions)
                {
                    winningCombinations.Add(combToCheck);
                }
            }

            Print(winningCombinations);
            Console.WriteLine($"Count of winner numbers: {winningCombinations.Count}");
        }

        static void Print(List<string> winningCombinations)
        {
            int lineCounter = 0;
            foreach (var comb in winningCombinations)
            {
                Console.Write($"{comb} ");
                lineCounter++;
            }
            Console.WriteLine();
        }

        static void CombinationsVariations(List<string> combinationsVariations)
        {
            for (int i1 = 0; i1 <= 9; i1++)
            {
                for (int i2 = 0; i2 <= 9; i2++)
                {
                    for (int i3 = 0; i3 <= 9; i3++)
                    {
                        for (int i4 = 0; i4 <= 9; i4++)
                        {
                            for (int i5 = 0; i5 <= 9; i5++)
                            {
                                var stringNum = ($"{i1}{i2}{i3}{i4}{i5}");
                                combinationsVariations.Add(stringNum);
                            }
                        }
                    }
                }
            }
        }
    }
}
