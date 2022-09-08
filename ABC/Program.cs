namespace ABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ints = Console.ReadLine().Split(" ");
            string ABC = Console.ReadLine();
            int[] oldOrder = new int[3];
            for (int i = 0; i < oldOrder.Length; i++)
            {
                oldOrder[i] = int.Parse(ints[i]);
            }
            Array.Sort(oldOrder);
            int A = oldOrder[0];
            int B = oldOrder[1];
            int C = oldOrder[2];
            int[] newOrder = new int[ints.Length];
            newOrder[ABC.IndexOf('A')] = A;
            newOrder[ABC.IndexOf('B')] = B;
            newOrder[ABC.IndexOf('C')] = C;
            foreach (int i in newOrder)
            {
                Console.Write(i + " ");
            }
        }
    }
}