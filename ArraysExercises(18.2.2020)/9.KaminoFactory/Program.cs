using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int dnaLength = int.Parse(Console.ReadLine());      // Useless in this solution
        string input = Console.ReadLine();      // String of 1s and 0s separated by ! or !`s
        int bestDnaSeqIndex = int.MaxValue;     // Longest sequence index
        int bestDnaSeqFinal = 0;        // Longest sequence length
        int finalSum = 0;       // Sum of the best DNA
        int[] result = new int[dnaLength];      // Best DNA to print
        int finalDna = 0;       // Best DNA index
        int Dna = 0;        // DNA index counter

        while (input != "Clone them!")
        {
            int[] currentDna = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //Converting the Input string to integer array of 1`s and 0`s(Current DNA)
            int currentSum = currentDna.Sum();
            //Sum of the current DNA
            int seqCounter = 0; 
            //Counter of 1`s for the current DNA
            int bestDnaSeq = 0; 
            //Counter for longest sequence of 1`s in the current DNA
            int bestDnaSeqIndexChecker = 0; 
            //Counter of the best sequence index (for the longest sequence of 1`s )in the current DNA
            Dna++;
            //current DNA index

            for (int i = 0; i < currentDna.Length; i++) 
            {
                if (currentDna[i] == 1)
                {
                    seqCounter++;
                    if (seqCounter > bestDnaSeq)
                    {
                        bestDnaSeq = seqCounter;
                        bestDnaSeqIndexChecker = (i + 2 - bestDnaSeq);
                    }
                }
                else
                {
                    seqCounter = 0;
                }
            }
            if (bestDnaSeq > bestDnaSeqFinal)
            {
                bestDnaSeqFinal = bestDnaSeq;
                finalSum = currentSum;
                bestDnaSeqIndex = bestDnaSeqIndexChecker;
                result = currentDna;
                finalDna = Dna;
            }
            if (bestDnaSeq == bestDnaSeqFinal && bestDnaSeqIndexChecker < bestDnaSeqIndex)
            {
                bestDnaSeqIndex = bestDnaSeqIndexChecker;
                result = currentDna;
                finalDna = Dna;
                finalSum = currentSum;
            }
            if (bestDnaSeq == bestDnaSeqFinal && bestDnaSeqIndexChecker == bestDnaSeqIndex && currentSum > finalSum)
            {
                finalSum = currentSum;
                result = currentDna;
                finalDna = Dna;
            }
            input = Console.ReadLine();

        }
        Console.WriteLine($"Best DNA sample {finalDna} with sum: {finalSum}.");
        Console.WriteLine(string.Join(" ", result));
    }
}

