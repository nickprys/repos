using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(6);
            Console.WriteLine("Square: " + rect.GetSquare());
            Console.WriteLine("Perimetr: " + rect.GetPerimetr());
            Console.ReadKey();
        }
    }
}
