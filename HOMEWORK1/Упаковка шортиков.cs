using System;
using System.Collections.Specialized;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string[] args)
        {
            short [] number=new short[4];
            long answer= 0;
            for (int i = 0; i < 4; i++)
            {
                number[i]=short.Parse(Console.ReadLine()); 
            }
            for (int i = 0; i < 4; i++)
            {
                answer <<= 16;
                answer |= number[number.Length-i-1];
            }
            Console.WriteLine(answer);

        }
    }
}