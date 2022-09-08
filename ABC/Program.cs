namespace ABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] oldOrder = Console.ReadLine().Split(" ").ToArray();
            string ABC = Console.ReadLine();
            Array.Sort(oldOrder);
            int A = int.Parse(oldOrder[0]);
            int B = int.Parse(oldOrder[1]);
            int C = int.Parse(oldOrder[2]);
            int[] newOrder = new int[oldOrder.Length];
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