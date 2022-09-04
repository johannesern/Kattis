namespace Apaxiaaaaaaaaaaaans_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputAsCharArray = input.ToCharArray();
            List<char> inputAsList = new List<char>();
            for (int i = 0; i < inputAsCharArray.Length; i++)
            {
                inputAsList.Add(inputAsCharArray[i]);
            }
            string name = inputAsList[0].ToString();
            bool run = true;
            int j = 0;
            int k = 1;
            int counter = 0;
            do
            {
                if (k == inputAsList.Count)
                {
                    run = false;
                }
                else if (inputAsList[j] != inputAsList[k])
                {
                    name += inputAsList[k].ToString();
                }
                j++;
                k++;
            } while (run);
            Console.WriteLine(name);
        }
    }
}