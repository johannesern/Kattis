namespace GCVWR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[]GCVWRtruckItems = MakeStringToIntArray(input);
            string weightItems = Console.ReadLine();
            int[] itemsSeparatedAsInt = MakeStringToIntArray(weightItems);
            float ninetyPercent = 0.9f;
            float GminusT = (GCVWRtruckItems[0] - GCVWRtruckItems[1]) * ninetyPercent;
            int itemsSum = 0;
            for (int i = 0; i < itemsSeparatedAsInt.Length; i++)
            {
                itemsSum += itemsSeparatedAsInt[i];
            }
            float weightOfTrailer;
            Console.WriteLine(weightOfTrailer = GminusT - itemsSum); 
        }
        public static int[] MakeStringToIntArray(string input)
        {
            string[] inputAsArr = input.Split(" ");
            int[] inputAsIntArr = new int[inputAsArr.Length];
            for (int i = 0; i < inputAsArr.Length; i++)
            {
                inputAsIntArr[i] = int.Parse(inputAsArr[i]);
            }
            return inputAsIntArr;
        }
    }
}