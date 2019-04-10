using System;
using System.Linq;

namespace FrogRiverOne
{
    public class FrogRiverOneSolution
    {
        public int Solution(int X, int[] A)
        {
            if (X > A.Length + 1)
                return -1;

            int maxElem = A.Max();
            int[] countingArr = new int[maxElem + 1 > A.Length + 1 ? maxElem + 1 : A.Length + 1];

            for (int i = 0; i < A.Length; i++)
            {
                bool isComplete = true;

                countingArr[A[i]]++;

                //Check if path is complete
                for (int j = 1; j <= X; j++)
                {
                    if (countingArr[j] == 0)
                    {
                        isComplete = false;
                        break;
                    }
                }

                if (isComplete)
                    return i;
            }

            return -1;
        }
    }
}
