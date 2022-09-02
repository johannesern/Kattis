namespace KATTIS_Greetings_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            char[] eS = input.ToCharArray();
            foreach(char e in eS)
            {
                if(e == 'e')
                {
                    counter++;
                }
            }
            int counterDouble = counter * 2;
            char[] manyEs = new char[counterDouble];
            for (int i = 0; i < counterDouble; i++)
            {
                manyEs[i] = 'e';
            }
            string manyEsAsString = new string(manyEs);
            Console.WriteLine("h" + manyEsAsString + "y");            
        }
    }
}