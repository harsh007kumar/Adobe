using System;

namespace ReverseWordsInAGivenString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "harsh kumar";
            ReverseWordsInAGivenString(str);
            Console.ReadLine();
        }

        private static void ReverseWordsInAGivenString(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i]);
        }
    }
}
