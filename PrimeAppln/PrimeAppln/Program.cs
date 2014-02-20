using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeAppln
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started");
            ulong i,n,j,c=0,sum=0;
            for (i = 1; i <= 1000000; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
            if(c==2)
            {
                sum += i;
               
           }
            c = 0;
            
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
