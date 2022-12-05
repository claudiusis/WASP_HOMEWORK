using System;

namespace WASP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите длину массива ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввод массива ");
            double[]mas=new double[n];
            for(int i = 0; i < mas.Length; i++)
            {
                mas[i]=Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Ввод k-го минимума ");
            int k;
            do
            {
                k=Convert.ToInt32(Console.ReadLine());
                if (k >= n || k<1)
                {
                    Console.WriteLine("Минимум за пределами значений массива...");
                }
            } while (k >= n || k<1);
            double cur;
            for (int i=0; i < mas.Length - 1; i++)
            {
                int minj = i;
                for (int j=i+1;j<mas.Length;j++)
                {
                    if (mas[j] < mas[minj]) minj = j;
                }
                cur = mas[i];
                mas[i] = mas[minj];
                mas[minj] = cur;
                if (i == (k-1))
                {
                    Console.WriteLine(k + "-й минимум: " + mas[i]);
                }
            }
            


        }
    }
}