using System.Net;

namespace Backspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();
            char[] input = Console.ReadLine().ToCharArray();
            input.ToList().ForEach(x => list.Add(x));
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == '<')
                {
                    list.RemoveAt(i);
                    list.RemoveAt(i - 1);
                    i = 0;
                }
                
            }
            char[] k = list.ToArray();
            //string l = String.Concat(k);
            //Console.WriteLine(l);
            string j = String.Join("", k);
            Console.WriteLine(j);
        }
    }
}