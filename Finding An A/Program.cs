namespace Finding_An_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int m = input.Length;
            int indexOfA = input.IndexOf("a");
            string n = input.Substring(indexOfA, m - indexOfA);
            Console.WriteLine(n);
        }
    }
}