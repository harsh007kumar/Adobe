using System;

namespace ElementWhoseSumIsClosetToZero
{
    // https://www.geeksforgeeks.org/two-elements-whose-sum-is-closest-to-zero/
    // Question: An Array of integers is given, both +ve and -ve. You need to find the two elements such that their sum is closest to zero.
    // Input : { 1, 60, -10, 70, -80, 85 };
    // Output: program should print -80 and 85.

    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 60, -10, 70, -80, 85 };
            int len = arr.Length;
            int n1 = 0, n2 = 0, sum = 99;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (i == j)
                        continue;
                    if (Math.Abs(arr[i] + arr[j]) < sum)
                    {
                        sum = Math.Abs(arr[i] + arr[j]);
                        n1 = arr[i];
                        n2 = arr[j];
                    }
                }
            }
            Console.WriteLine(n1 + " " + n2);
        }
    }
}
