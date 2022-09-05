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
                Console.WriteLine(Math.Abs(longs[0] - longs[1]));
            }
        }
    }
}