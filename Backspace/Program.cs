namespace Backspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputToCharArray = input.ToCharArray();
            List<char> inputCharList = new List<char>();

            foreach (char c in inputToCharArray)
            {
                inputCharList.Add(c);
            }
            int counterOfCroc = 0;
            foreach (char d in inputCharList)
            {
                if(d == '<')
                    counterOfCroc++;
            }
            for (int i = 0; i < counterOfCroc; i++)
            {
                for (int j = 0; j < inputCharList.Count; j++)
                {
                    if (inputCharList[j] == '<')
                    {
                        inputCharList.RemoveAt(j);
                        inputCharList.RemoveAt(j - 1);
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < inputCharList.Count; i++)
            {
                Console.Write(inputCharList[i]);
            }
        }       
    }
}