using System;

namespace WASP
{
    class Program
    {
        public static void Main(string[] args)
        {
            double answer = 0;
            Console.Write("Введите значение длины вектора: ");
            int n = int.Parse(Console.ReadLine());
            double p;
            do
            {
                Console.Write("Введите значение порядка нормы: ");
                p = double.Parse(Console.ReadLine());
                if (p < 1 || (int)p!=(double)p)
                {
                    Console.WriteLine("Порядок должен быть >=1 и желательно целый");
                }
            } while (p < 1 || (int)p != (double)p);
            double [] vect = new double[n];
            for (int i=0; i < n; i++)
            {
                vect[i]=Convert.ToDouble(Console.ReadLine());
            }
            foreach(double num in vect)
            {
                answer += Math.Pow(num, p);
            }
            answer = Math.Pow(answer, 1/p);
            Console.WriteLine(answer);
        }
    }
}