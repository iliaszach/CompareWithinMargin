using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareWithinMargin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CloseCompare(-4,-5));
        }


        public static int CloseCompare(double a, double b, double margin = 0)
        {
            //grab the difference between a,b
            if (Math.Abs(a - b) <= margin) return 0;
            return a<b? -1 : 1 ;
        }

    }
}
