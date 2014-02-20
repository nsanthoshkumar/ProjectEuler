using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenlyDivisible20
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n,i,j,c=0;
            for(n=1;n>0;n++)
            {
                c = 0;
                for (i = 1; i <= 20; i++)
                {
                    try
                    {
                        if (n % i == 0)
                        {
                            //Console.WriteLine(n);
                            c++;
                            //Console.WriteLine(c);
                        }
                    }
                    catch (InsufficientMemoryException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    }
                //Console.WriteLine("n"+n);
                //Console.WriteLine("c"+c);
                if (c == 20)
                    {
                        Console.WriteLine(n);
                        break;
                    }
                c = 0;
                           }
            Console.ReadLine();
        }
    }
}
