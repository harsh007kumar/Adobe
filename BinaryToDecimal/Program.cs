using System;

namespace BinaryToDecimal
{
    /* Given a binary number as input, we need to write a program to convert the given binary number into equivalent decimal number.
        Examples:
        Input : 111
        Output : 7

        Input : 1010
        Output : 10

        Input: 100001
        Output: 33
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            BinaryToDecimal(100001);
            Console.ReadLine();
        }

        private static void BinaryToDecimal(int no)
        {
            double result = 0,i=0;
            while(no>0)
            {
                if (no % 10 == 1)
                {
                    result += Math.Pow(2, i);
                }
                no /= 10;
                i++;
            }
            Console.WriteLine($"The Decimal No is : {result}");
        }
    }
}
