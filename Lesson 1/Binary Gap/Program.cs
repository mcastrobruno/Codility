using System;

namespace Binary_Gap
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = Solution(1162);
            Console.WriteLine(result);
        }
        // 500 = 1000010100


        public static int Solution(int N)
        {
            string binaryNumber = Convert.ToString(N, 2);

            int currentGap = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '1') //Procura pelo próximo GAP
                {
                    int localGap = 0;
                    for (int j = i + 1; j < binaryNumber.Length; j++)
                    {
                        if (binaryNumber[j] == '0')
                        {
                            localGap++;
                        }
                        else
                        {
                            if (localGap > currentGap)
                                currentGap = localGap;

                            i = j - 1;

                            break;
                        }
                    }
                }
            }
            return currentGap;
        }
    }
}
