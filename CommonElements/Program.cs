using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] second = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string common = String.Empty;

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (second[i]==first[j])
                    {
                        common += second[i] + " ";
                    }
                }
            }
            Console.WriteLine(common);
        }
    }
}
