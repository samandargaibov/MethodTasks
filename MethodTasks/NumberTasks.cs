using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTasks
{
    internal class NumberTasks
    {
        internal int EnterNumber()
        {
            Console.Write("Reqemi daxil edin: ");
            int n = int.Parse(Console.ReadLine());

            int r;
            int reverse = 0;
           
            while (n != 0)
            {
                r = n % 10;
                reverse = reverse * 10 + r;
                n /= 10;
            }

            return reverse;
        }

        internal void Print(int n)
        {
            Console.WriteLine(n);
        }
    }
}
