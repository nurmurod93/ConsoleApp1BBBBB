using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method_1
{
    public static class Generic_Variant
    {
        public static void ToqJuft<T>(this T raqam) where T : struct 
        {
            if(raqam is int)
            {
                if ((int)(object)raqam % 2 == 0)
                {
                    Console.WriteLine("juft");
                }
                else 
                {
                    Console.WriteLine("toq");
                }
            }
            else if(raqam is short)
            {
                if ((short)(object)raqam % 2 == 0)
                {
                    Console.WriteLine("juft");
                }
                else
                {
                    Console.WriteLine("toq");
                }
            }
            else if (raqam is double)
            {
                if ((double)(object)raqam % 2 == 0)
                {
                    Console.WriteLine("juft");
                }
                else
                {
                    Console.WriteLine("toq");
                }
            }
            else if (raqam is float)
            {
                if ((float)(object)raqam % 2 == 0)
                {
                    Console.WriteLine("juft");
                }
                else
                {
                    Console.WriteLine("toq");
                }
            }
            else if (raqam is long)
            {
                if ((long)(object)raqam % 2 == 0)
                {
                    Console.WriteLine("juft");
                }
                else
                {
                    Console.WriteLine("toq");
                }
            }
        }
    }
}
