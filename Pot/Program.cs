namespace Pot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32.TryParse(Console.ReadLine(), out int inputRounds);
            string inputAsString = "";
            string input2 = "";
            int counter = 0;
            while (counter < inputRounds)
            {
                input2 = Console.ReadLine();
                inputAsString += input2 + " ";
                counter++;
            }
            string[] inputToArray = new string[inputRounds];
            inputToArray = inputAsString.Split(' ');
            double result = 0;
            for (int i = 0; i < inputRounds; i++)
            {
                int lengthOfInt = inputToArray[i].Length - 1;
                string lastOfEachString = inputToArray[i].Last().ToString();
                inputToArray[i] = inputToArray[i].ToString().Remove(lengthOfInt);
                int intToPow = int.Parse(inputToArray[i]);
                int powInt = int.Parse(lastOfEachString);
                result += Math.Pow(intToPow, powInt);
            }
            Console.WriteLine(result);
        }
    }
}