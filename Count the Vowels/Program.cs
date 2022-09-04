namespace Count_the_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToUpper();
            int counter = 0;
            foreach (char i in input)
            {
                switch (i)
                {
                    case 'A':
                        counter++;
                        break;
                    case 'E':
                        counter++;
                        break;
                    case 'I':
                        counter++;
                        break;
                    case 'O':
                        counter++;
                        break;
                    case 'U':
                        counter++;
                        break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}