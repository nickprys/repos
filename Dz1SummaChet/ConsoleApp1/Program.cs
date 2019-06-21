using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first num: ");
            string name = Console.ReadLine();
            var number = int.Parse(name);
            Console.Write("sec num: ");
            string namesec = Console.ReadLine();
            var numbersec = int.Parse(namesec);
            int sum = 0;
            
            for ( int i = number; i <= numbersec; i = i + 2 )
            {
                //if (i % 2 == 0)
                sum += i;
               
            }
            Console.Write(sum);
            Console.ReadLine();
        }
        
        
    }
}
