namespace Backspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int x = 0;
            EraseChar(x, input);
        }
        public static void EraseChar(int x, string input)
        {
            int y = input.Length;
            if (x == y)
            {
                Console.WriteLine(input);
                return;
            }
            else if (input[x] == '<')
            {
                input = input.Remove(x - 1, 2);
                x = x - 1;
                EraseChar(x, input);
            }              
            else
            {
                EraseChar(x + 1, input);
            }
        }
    }
}