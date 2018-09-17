using System;

namespace Odd_Occurrences_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2, 3, 2, 1 };

            var result = solution(new int[] { 1, 2, 3, 2, 1 });

            foreach (var t in a)
            {
                Console.WriteLine(Convert.ToString(t,2));
            }

            Console.WriteLine("Result: " + result);
        }


        public static int solution(int[] A)
        {
            int unpaired = 0;

            foreach (var i in A)
            {
                unpaired ^= i;
            }

            return unpaired;
        }
    }
}
