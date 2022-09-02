namespace FYI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int value);
            char[] valueNowChar = value.ToString().ToCharArray();
            string[] valueNowStringArray = new string[valueNowChar.Length];
            for (int i = 0; i < valueNowChar.Length; i++)
            {
                valueNowStringArray[i] = valueNowChar[i].ToString();
            }
            int controlSum = 0;
            for (int i = 0; i < 3; i++)
            {
                controlSum += Convert.ToInt32(valueNowStringArray[i]);
            }
            if (controlSum == 15)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}