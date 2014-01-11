using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciApplnEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
             long x=0,y=1,z,c=1,n=4000000,m=0;
             while (m<=4000000)
             {
                 z = x + y;
                 if (z % 2 == 0)
                 {
                     m += z;
                     if ((m <= 4000000))
                     {
                         Console.WriteLine(z);
                       
                     }
                }
                 x = y;
                 y = z;
                 c++;
             }
             Console.WriteLine(m);
             Console.ReadLine();
        }
    }
}
