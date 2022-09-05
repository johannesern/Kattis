namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] inputAsInts = MakeStringToIntArray(input);
            int x = inputAsInts[0];
            int y = inputAsInts[1];
            int n = inputAsInts[2];
            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % x == 0 && i % y != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % y == 0 && i % x != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % x != 0 && i % y != 0)
                {
                    Console.WriteLine(i);
                }
            }
         }
        public static int[] MakeStringToIntArray(string input)
        {
            string[] inputAsArr = input.Split(" ");
            int[] inputAsIntArr = new int[inputAsArr.Length];
            for (int i = 0; i < inputAsArr.Length; i++)
            {
                inputAsIntArr[i] = int.Parse(inputAsArr[i]);
            }
            return inputAsIntArr;
        }
    }
}