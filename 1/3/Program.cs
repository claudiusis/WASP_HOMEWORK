using System;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите воординаты первой точки: ");
            int x1 = Convert.ToInt32(Console.ReadLine()), y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите воординаты второй точки: ");
            int x2 = Convert.ToInt32(Console.ReadLine()), y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите воординаты третьей точки: ");
            int x3 = Convert.ToInt32(Console.ReadLine()), y3 = Convert.ToInt32(Console.ReadLine());
            int maxx = 0,maxy=0;
           
            //Определение границ
            if (x1 >= x2 && x1>=x3)
            {
                maxx = x1;
            }
            else if (x2>=x1 && x2>=x3)
            {
                maxx = x2;
            }
            else
            {
                maxx = x3;
            }

            if (y1 >= y2 && y1 >= y3)
            {
                maxy = y1;
            }
            else if (y2 >= y1 && y2 >= y3)
            {
                maxy = y2;
            }
            else
            {
                maxy = y3;
            }

            if (!((x2==x1 && y2==y1)||(x2 == x3 && y2 == y3)||(x3 == x1 && y3 == y1)))
            {
                for (int y0 = 0; y0 <= maxy; y0++)
                {
                    for (int x0=0; x0 <= maxx; x0++)
                    {
                        int a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
                        int b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
                        int c = (x3-x0)*(y1-y3)-(x1-x3)*(y3-y0);
                        if ((a>=0 && b>=0 && c>=0) || (a<=0 && b<=0 && c <= 0))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Необходимо три различных значения координат");
            }
        }
    } 
}