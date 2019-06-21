using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_io
{
    class Program
    {
        static void Main(string[] args)
        {
            int fnum = Convert.ToInt32(Console.ReadLine());
            int snum = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = fnum; i <= snum; i = i + 2)
            {
                //if (i % 2 == 0)
                sum += i;
            }
            Console.Write(sum);
            Console.ReadLine();
        }
    }

}
