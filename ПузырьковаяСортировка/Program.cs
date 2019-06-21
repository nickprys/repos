using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПузырьковаяСортировка
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] BubbleSortOnce(int[] S)
            {
                int i, z, x = 0, y, tmp;
                for (y = x; y >= 0; y--)
                    if (S[y] > S[y + 1])
                    {
                        tmp = S[y];
                        S[y] = S[y + 1];
                        S[y + 1] = tmp;
                    }
                return S;
            }
        }
    }
}
