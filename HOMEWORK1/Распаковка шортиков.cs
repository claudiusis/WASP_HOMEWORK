using System;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string[] args)
        {
            short[] numbers = new short[4];
            short k = 32767;
            Console.Write("Введите \"запакованные шортики\"");
            long chislo = long.Parse(Console.ReadLine());
            for (int i= 0; i < 4; i++)
            {
                numbers[i] = (short)(chislo&k);
                chislo >>= 16;
            }
            for (int i=0; i < 4; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}