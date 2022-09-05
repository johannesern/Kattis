namespace Tree_Insertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int howManyNumbers);
            string[] incomingInts = Console.ReadLine().Split(" ");            
            int[] intArr = new int[incomingInts.Length];
            for (int i = 0; i < howManyNumbers; i++)
            {
                intArr[i] = int.Parse(incomingInts[i]);
            }
            List<int> lesserThanStartPos = new List<int>();
            List<int> largerThanStartPos = new List<int>();
            foreach(int i in intArr)
            {
                if(i < intArr[0])
                {
                    lesserThanStartPos.Add(i);
                }
                else
                {
                    largerThanStartPos.Add(i); 
                }
            }
            int counter = 0;
            int BSTcounter = 0;
            while (counter < howManyNumbers)
            {
                for (int i = 1; i < howManyNumbers; i++)
                {

                }
            }
        }
        public static int Comparer(int x, int y)
        {
            int anInt = 0;

            return anInt;
        }

        public static int[] ChangeOrder(int[] intArr)
        {
            int temp = intArr[0];
            for (int i = 1; i < intArr.Length; i++)
            {
                intArr[i] = intArr[i + 1];
            }
            intArr[intArr.Length] = temp;
            return intArr;
        }
    }
}