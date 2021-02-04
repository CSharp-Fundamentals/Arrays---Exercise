using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] first=new string[n];
            string[] second=new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (i%2==0)
                {
                    first[i] = array[0];
                    second[i] = array[1];
                }
                else
                {
                    first[i] = array[1];
                    second[i] = array[0];
                }
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}
