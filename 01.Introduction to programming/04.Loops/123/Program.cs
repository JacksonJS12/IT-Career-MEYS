using System;
using System.Linq;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the length of the DNA sequences from the input
            int length = int.Parse(Console.ReadLine());

            // Initialize variables to keep track of the longest subsequence of ones and the sequence with the leftmost starting index
            int longestSubsequenceLength = 0;
            int leftmostStartIndex = -1;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            string bestSequence = "";

            // Read the DNA sequences from the input until the "Clone them!" command is received
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                // Parse the DNA sequence from the input
                string[] sequence = input.Split('!');

                // Count the number of ones in the DNA sequence
                int onesCount = 0;
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == "1")
                    {
                        onesCount++;
                    }
                }

                // Check if the DNA sequence has the longest subsequence of ones
                if (onesCount > longestSubsequenceLength)
                {
                    longestSubsequenceLength = onesCount;
                    leftmostStartIndex = sequence[0].IndexOf('1');
                    bestSequenceIndex = onesCount;
                    bestSequenceSum = sequence.Sum(x => int.Parse(x));
                    bestSequence = string.Join(" ", sequence);
                }
                else if (onesCount == longestSubsequenceLength)
                {
                    // Check if the DNA sequence has the leftmost starting index
                    int startIndex = sequence[0].IndexOf('1');
                    if (startIndex < leftmostStartIndex)
                    {
                        leftmostStartIndex = startIndex;
                        bestSequenceIndex = onesCount;
                        bestSequenceSum = sequence.Sum(x => int.Parse(x));
                        bestSequence = string.Join(" ", sequence);
                    }
                    else if (startIndex == leftmostStartIndex)
                    {
                        // Check if the DNA sequence has the greatest sum of its elements
                        int sum = sequence.Sum(x => int.Parse(x));
                        if (sum > bestSequenceSum)
                        {
                            bestSequenceIndex = onesCount;
                            bestSequenceSum = sum;
                            bestSequence = string.Join(" ", sequence);
                        }
                    }
                }
            }
        }
    }
}