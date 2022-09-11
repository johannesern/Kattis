namespace Pokerhand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] theCard = Console.ReadLine().Split(" ");
            int[] counter = new int[theCard.Length];
            List<char> list = new List<char>();
            for (int i = 0; i < theCard.Length; i++)
            {
                if (!list.Contains(theCard[i][0]))
                {
                    list.Add(theCard[i][0]);
                    counter[i]++;
                    for (int j = 1; j < theCard.Length; j++)
                    {
                        if (theCard[i][0] == theCard[j][0] && theCard[i][1] != theCard[j][1])
                        {
                            counter[i]++;
                        }
                    }
                }
            }
            Array.Sort(counter);
            Console.WriteLine(counter[4]);
        }
    }
}