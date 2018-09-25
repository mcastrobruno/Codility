using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Solution(1, 100, 1);

            Console.WriteLine($"Resultado: {result}");
        }

        static public int Solution(int X, int Y, int D)
        {
            double subtraction = Y-X;
            double count = (double)(subtraction/D);            
            return (int)Math.Ceiling(count);
        }
    }
}
