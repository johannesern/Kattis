using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(" ");
            int[] inputAsInts = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputAsInts[i] = int.Parse(inputArray[i]);
            }
            int R1 = inputAsInts[0];
            int S = inputAsInts[1];
            if (-1000 < R1 && R1 < 1000 && R1 != 0)
            {
                if (-1000 < S && S < 1000 && S != 0)
                {
                    int R2 = S * 2 - R1;
                    Console.WriteLine(R2);
                    Console.ReadLine();
                }
            }
        }
    }
}