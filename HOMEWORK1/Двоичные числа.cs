using System;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string ans = Convert.ToString(n), number = "";
            while (n != 0)
            {
                number = Convert.ToString(n & 1) + number;
                n = n >> 1;
            }
            Console.Write(ans + "->" + number);
            Console.ReadKey();
        }
    }
}