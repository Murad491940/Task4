using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MathHelper
{
    internal class MathHelper
    {
        public static int PritValue(int a,int b)
        {
            return a + b;
        }
        public static int PritValue(bool a)
        {

            if (a == true) ; return 1;
            if (a == false)  return 0;

            
        }
        public static void PritValue(string name,string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }
        public static int PritValue(int a, int b,int c)
        {
            return a * b * c;
        }

    }
}
