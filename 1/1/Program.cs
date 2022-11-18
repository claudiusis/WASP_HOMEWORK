using System;
using System.Security.Cryptography.X509Certificates;

namespace WASP_HOMEWORK
{
    class Program
    {
        public static void Main(string [] args)
        {
            for (int i = 9; i >= 3; i--)
            {
                for(int j=i-1; j>=2; j--)
                {
                    for (int k=j-1; k >= 1; k--)
                    {
                        for (int m = k - 1; m >= 0; m--)
                        {
                            Console.WriteLine(i + "" + j + "" + k + "" + m);                             
                        }
                    }
                }
            }
        }
    }
}
