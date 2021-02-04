using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int top = arr[i];
                bool isTop = true;

                for (int j = i+1; j < arr.Length; j++)
                {
                    int rightNum = arr[j];

                    if (top<=rightNum)
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write($"{top} ");
                }
            }
        }
    }
}
