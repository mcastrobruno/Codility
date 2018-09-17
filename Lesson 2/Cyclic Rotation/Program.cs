using System;

namespace Cyclic_Rotation
{
    class Program
    {



        static void Main(string[] args)
        {
            var result = solution(new int[] { 3, 8, 9, 7, 6 }, 3);

            foreach (var n in result)
                Console.Write(n);

        }


        public static int[] solution(int[] A, int K)
        {
            while (K > 0)
            {
                int aux = -1;

                for (int i = 0; i < A.Length; i++)
                {
                    if (i == 0)
                    {
                        aux = A[i];
                        var lastElement = A[A.Length - 1];
                        A[i] = lastElement;
                    }
                    else
                    {
                        int next = A[i];
                        A[i] = aux;
                        aux = next;
                    }
                }
                K--;
            }
            return A;
        }
    }
}
