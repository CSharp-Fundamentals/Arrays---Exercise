using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int bestSequenceSize = 0;
            int bestSequenceNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                int counter = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];

                    if (currentNumber==rightNumber)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter>bestSequenceSize)
                {
                    bestSequenceSize = counter;
                    bestSequenceNumber = currentNumber;
                }
            }
            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSequenceNumber} ");
            }
        }
    }
}
