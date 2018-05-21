using static MyLibrary.MyMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 5));
            Console.ReadLine();

            int x = y = z = 0;
            A(x, ref y, out z);
            Console.WriteLine($"{x}, {y}, {z}");
            Console.ReadLine();
        }

        static void A(int a, ref int b, out int c)
        {
            a = 1;
            b = 2;
            c = 3;
        }
    }
}
