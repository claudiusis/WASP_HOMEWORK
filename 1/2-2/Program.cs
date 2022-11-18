using System;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ввод: ");
            int m=Convert.ToInt32(Console.ReadLine()), n=Convert.ToInt32(Console.ReadLine());
            int answer=m+n;
            Console.WriteLine("Вывод: ");
            string number="", numans="";
            while (answer != 0)
            {
                numans = Convert.ToString(answer & 1) + numans;
                answer >>= 1;
            }
            while (m != 0)
            {
                number=Convert.ToString(m&1)+number;
                m =m >> 1;
            }
            while (number.Length != numans.Length)
            {
                number = "0" + number;
            }
            Console.WriteLine(number);
            number = "";
            while (n != 0)
            {
                number = Convert.ToString(n&1) + number;
                n =n>> 1;
            }
            while (number.Length != numans.Length)
            {
                number = "0" + number;
            }
            Console.WriteLine(number);
            for (int i = 0; i < numans.Length; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Console.WriteLine(numans);

        } 
    }
}