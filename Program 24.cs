using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int a = 0,i=1, n=1 ;
            do
            {
                n = n * i;
                i++;
            } while (i <= p);
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
