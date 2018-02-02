using System;

namespace CountSetBitsInAnInteger
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CountSetBitsInAInteger(65455);
            Console.ReadLine();
        }
        static void CountSetBitsInAInteger(int no)
        {
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((no & (1 << i)) != 0)
                { count++; }
            }
            Console.WriteLine(count);
        }
    }
}
