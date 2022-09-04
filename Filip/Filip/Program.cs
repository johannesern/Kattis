namespace Filip
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            string input = Console.ReadLine();
            char[] cInput = input.ToCharArray();
            Array.Reverse(cInput);
            input = string.Concat(cInput);
            string[] inputArr = input.Split(" ");
            if (int.Parse(inputArr[0]) < int.Parse(inputArr[1]))
            {
                Console.WriteLine(inputArr[1]);
            }
            else
            {
                Console.WriteLine(inputArr[0]);
            }
        }
    }
}