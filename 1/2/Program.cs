using System;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы: ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итоговая матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j=0; j<n;j++)
                {
                    if (i == j)
                    {
                        Console.Write(n);
                    }
                    else
                    {
                        Console.Write(n-Math.Abs((i-j)));
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
