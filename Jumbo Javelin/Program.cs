namespace Jumbo_Javelin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int numberOfRods);
            int counter = 0;
            int totalRodLength = 0;

            Int32.TryParse(Console.ReadLine(), out int firstRod);
            while (counter < (numberOfRods - 1))
            {
                Int32.TryParse(Console.ReadLine(), out int nRod);
                firstRod += nRod - 1;
                totalRodLength = firstRod;
                counter++;
            }
            Console.WriteLine(totalRodLength);
        }
    }
}