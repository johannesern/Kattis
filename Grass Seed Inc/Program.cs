namespace Grass_Seed_Inc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string costOfSeedString = Console.ReadLine();
            double costOfSeed = double.Parse(costOfSeedString);
            string lawnsToSowString = Console.ReadLine();
            int lawnsToSow = int.Parse(lawnsToSowString);
            double[] lawnSizeWidthLengthDouble = new double[2];
            double lawnSizeTotalArea = 0;
            int counter = 0;
            while(counter < lawnsToSow)
            {
                string widthLength = Console.ReadLine();
                string[] widthLengthArr = widthLength.Split(" ");
                lawnSizeWidthLengthDouble[0] = double.Parse(widthLengthArr[0]);
                lawnSizeWidthLengthDouble[1] = double.Parse(widthLengthArr[1]);
                double temp = (lawnSizeWidthLengthDouble[0] * lawnSizeWidthLengthDouble[1]);
                lawnSizeTotalArea += temp;
                counter++;
            }
            lawnSizeTotalArea *= costOfSeed;
            Console.WriteLine(lawnSizeTotalArea);
        }
    }
}