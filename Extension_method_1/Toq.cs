using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method_1
{
    public static class Toq
    {
        public static void ToqYokiJuftSonlar(this int kiruvchi)
        {
            if(kiruvchi % 2 == 0)
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
