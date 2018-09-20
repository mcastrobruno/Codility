using System;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10] { 1, 4, 2, 3, 7, 9, 10, 6, 8, 0 };

            int missingElement = Solution(A);

            Console.WriteLine($"Missing Elmement {missingElement}");
        }


        static int Solution(int[] A)
        {
            throw new NotImplementedException();
        }
    }
}
