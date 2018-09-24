using System;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[4] { 2, 3, 1, 5 };

            int missingElement = Solution(A);
            Console.WriteLine($"Solution: {missingElement}");
        }


        static int Solution(int[] A)
        {
            long n = A.Length + 1;
            int a1 = 1;
            long sum = 0;

            foreach (int el in A)
            {
                sum += el;
            }

            long sumTotal = ((a1 + n) * n) / 2;

            return (int)(sumTotal - sum);
        }
    }
}
