namespace Kattis_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int R1);
            if (-1000 < R1 && R1 < 1000 && R1 != 0)
            {
                Int32.TryParse(Console.ReadLine(), out int S);
                if (-1000 < S && S < 1000 && S != 0)
                {
                    int R2 = S * 2 - R1;
                    Console.WriteLine(R2);
                    Console.ReadLine();
                }
            }            
        }
    }
}