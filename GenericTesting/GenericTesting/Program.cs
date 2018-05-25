using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTesting
{
    class Program
    {
        static void Swap<T> (ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }

        static void DynamicSwap (ref dynamic a, ref dynamic b)
        {
            dynamic t = a;
            a = b;
            b = t;
        }

        static void Main(string[] args)
        {
            int a = 12, b = 7;
            Console.WriteLine($"{a} {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"{a} {b}");

            string x = "Hello", y = "Hihi";
            Console.WriteLine($"{x} {y}");
            Swap<string>(ref x, ref y);
            Console.WriteLine($"{x} {y}");

        }
    }
}
