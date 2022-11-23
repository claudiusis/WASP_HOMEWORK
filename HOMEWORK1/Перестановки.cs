using System;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine()), n1,n2,koef=255;
            int k=Convert.ToInt32(Console.ReadLine()), m=Convert.ToInt32(Console.ReadLine());
            if ((k >= 1 && k <= 8) && (m >= 1 && m <= 8))
            {
                if (k == m)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    n1 = (n >> (8 * (k - 1))) & koef;
                    n2 = (n >> (8 * (m - 1))) & koef;
                    n |= (koef << (8 * (k - 1)));
                    n |= (koef << (8 * (m - 1)));
                    n ^= (koef << (8 * (k - 1)));
                    n ^= (koef << (8 * (m - 1)));
                    n |= n1 << (8 * (m - 1));
                    n |= n2 << (8 * (k - 1));
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("Out of range(k or m)");
            }
        }
    }
}