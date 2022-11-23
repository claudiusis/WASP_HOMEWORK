using System;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите натуральное число n - высоту треугольника Паскаля: ");
            ulong n = Convert.ToUInt16(Console.ReadLine());
            ulong k;
            for (ulong i=0; i < n; i++)
            {
                k = 1;
                Console.Write(k);
                for (ulong j = 1; j <= i; j++)
                {
                    k *= i - j + 1;           //Что если заменить на:
                    k /= j;                  //k = (k * (i - j + 1)) / j;
                    Console.Write(" ");
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
}