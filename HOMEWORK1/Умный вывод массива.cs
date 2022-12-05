using System;

namespace WASP
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sizemas=Convert.ToInt32(Console.ReadLine()), start, end;
            int step;
            int[] mas=new int[sizemas];
            for (int i = 0; i < sizemas; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            string enter=Console.ReadLine();
            string [] str=enter.Split(":");
            start = Convert.ToInt32(str[0]);
            end = Convert.ToInt32(str[1]);
            step = Convert.ToInt32(str[2]);
            if ((step>sizemas)|| (start > sizemas || start < 0)||((end > sizemas || end < 0))){
                Console.WriteLine("[]");
            }
            else
            {
                //как я понял задание, если шаг>0 => идём слева направо, если <0 =>
                //справа-налево
                if (start > end)
                {
                    int o = start;
                    start= end;
                    end= o;
                }
                if (step == 0 || start==end)
                {
                    Console.WriteLine("[]");
                }
                else if (step>0)
                {
                    for (int i = start; i <= end; i += step)
                    {
                        Console.Write(mas[i]+" ");
                    }
                }
                else
                {
                    for (int i=end; i>=start; i += step)
                    {
                        Console.Write(mas[i] + " ");
                    }
                }
            }



        }
    }
}