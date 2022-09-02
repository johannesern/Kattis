namespace ITHS_KATTIS_Job_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //=============== Input 1 =========================================
            Input1();

            //=============== Input 2 =========================================
            Input2();

            //=============== Input 3 =========================================
            Input3();

            bool run = true;
            while (run)
            {
                //=============== Input Own Numbers ===============================
                Input4();
                Console.ReadLine();
            }           
        }

        public static void Input1()
        {
            string input1 = "3";
            string input2 = "1 -2 3";
            FancyStuffGoingOn(input1, input2);
        }

        public static void Input2()
        {
            string input1 = "5";
            string input2 = "129 44 394 253 147";
            FancyStuffGoingOn(input1, input2);
        }

        public static void Input3()
        {
            string input1 = "10";
            string input2 = "-100 40000 -6500 -230 -18 34500 -450 13000 -100 5000";
            FancyStuffGoingOn(input1, input2);
        }

        public static void Input4()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            FancyStuffGoingOn(input1, input2);
        }

        public static void FancyStuffGoingOn(string input1, string input2)
        {
            string incAndExp = input1 + " " + input2;
            string[] incAndExpStringArray = incAndExp.Split(" ");
            int[] incAndExpIntArray = new int[incAndExpStringArray.Length];
            for (int i = 0; i < incAndExpStringArray.Length; i++)
            {
                incAndExpIntArray[i] = int.Parse(incAndExpStringArray[i]);
            }
            int exp = 0;
            int expSum = 0;
            for (int i = 0; i < incAndExpIntArray.Length; i++)
            {
                if (incAndExpIntArray[i] < 1)
                {
                    expSum = exp + incAndExpIntArray[i];
                    exp = expSum;
                }
            }
            if (expSum < 0)
            {
                expSum = expSum * -1;
            }
            Console.WriteLine(expSum);
        }
    }
}