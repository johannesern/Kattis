namespace Eye_of_Sauron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sauronsEyeInMid = Console.ReadLine();
            int midOfSentence = Convert.ToInt32(sauronsEyeInMid.Length / 2);
            if(Convert.ToInt32(sauronsEyeInMid.Length) % 2 == 0)
            {
                if (sauronsEyeInMid.IndexOf("(") + 1 == midOfSentence)
                {
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("fix");
                }
            }
            else
            {
                Console.WriteLine("fix");
            }            
        }
    }
}