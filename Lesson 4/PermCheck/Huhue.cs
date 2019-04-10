using System;
using System.Linq;

namespace PermCheck
{
    public class PermChecker
    {
        public int Solution(int[] A)
        {
            if (A.Length == 0)
                return 0;
            else if (A.Contains(0))
                return 0;

            int n = A.Length;
            int[] countingArr = new int[A.Length + 1];

            bool isPermutation = true;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A.Length)
                {
                    isPermutation = false;
                    break;
                }

                countingArr[A[i]] += 1;
                if (countingArr[A[i]] > 1)
                {
                    isPermutation = false;
                    break;
                }
            }

            return isPermutation ? 1 : 0;
        }
    }
}
