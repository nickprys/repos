using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
           // int[] nums2 = new int[4] { 1, 2, 3, 5 };
            {
                int[] array = { 1, 2, 3, 4, 5 };
                Array.Reverse(array);

                var s = string.Join(" ", array);
                // Reverses the sort of the values of the Array.
                

                // Displays the values of the Array.
                Console.WriteLine("After reversing:");
                
                Console.WriteLine(s);
                Console.ReadKey();
            }
        }
    }
}
