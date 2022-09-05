namespace A_Different_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string line;
            string[] temp;
            long[] longs = new long[2];
            while((line = Console.ReadLine()) != null)
            {
                temp = line.Split(" ");
                for (int i = 0; i < longs.Length; i++)
                {
                    longs[i] = long.Parse(temp[i]);
                }
                if (longs[0] < longs[1])
                {
                    long res = longs[1] - longs[0];
                    Console.WriteLine(res);
                }
                else
                {
                    long res = longs[0] - longs[1];
                    Console.WriteLine(res);
                }
            }
        }
    }
}