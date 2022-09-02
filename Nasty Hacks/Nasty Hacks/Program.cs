namespace Nasty_Hacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int counter = 0;
            string input = Console.ReadLine();
            int inputAsInt = int.Parse(input);
            while (counter < inputAsInt)
            {
                string input2 = Console.ReadLine();
                string[] nAsArray = input2.Split(" ");
                int[] ints = new int[nAsArray.Length];
                int inkomstUtanReklam = 0;
                int inkomstMedReklam = 0;
                int reklamKostnad = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    ints[i] = Convert.ToInt32(nAsArray[i]);
                }
                if (ints.Length < 3)
                {
                    inkomstUtanReklam = ints[0];
                }
                else if (ints.Length > 2)
                {
                    inkomstUtanReklam = ints[0];
                    inkomstMedReklam = ints[1];
                    reklamKostnad = ints[2];
                }
                if (inkomstMedReklam - reklamKostnad > inkomstUtanReklam)
                {
                    result = result + "advertise\n";
                }
                else if (inkomstMedReklam - reklamKostnad == inkomstUtanReklam)
                {
                    result = result + "does not matter\n";
                }
                else if (inkomstMedReklam - reklamKostnad < inkomstUtanReklam)
                {
                    result = result + "do not advertise\n";
                }

                counter++;
            }
            Console.WriteLine(result);
        }
    }
}