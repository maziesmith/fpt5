using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateTesting
{
    delegate int FirstDelegate(int x);

    delegate int ThirdDelegate(int a, int b);

    class Program
    {
        public delegate void SecondDelegate();

        static int Square(int x)
        {
            return x * x;
        }

        static void Print() => Console.WriteLine("Hello");

        static void Display()
        {
            Thread.Sleep(2000);
            Console.WriteLine("World");
        }

        static void Execute(SecondDelegate d)
        {
            d();
        }

        static void Testing(Func<int, int, int> f)
        {
            Console.WriteLine(f(12, 4));
        }

        static void Main(string[] args)
        {
            //FirstDelegate first = new FirstDelegate(Square);
            //Console.WriteLine(first(3));
            //SecondDelegate second = Print;
            //second += Display;
            //second.Invoke();
            //second -= Print;
            //second();
            //Execute(second);
            //Execute(() => Console.WriteLine("This is a lambda"));
            //second.BeginInvoke(null, null);
            //Display();
            //FirstDelegate d = delegate (int a) {
            //    return a * a;
            //};
            //Console.WriteLine(d(3));
            //ThirdDelegate d = (a, b) => a * b;
            //Console.WriteLine(d(6, 7));
            //Func<int, int, int> f = (a, b) => a + b;
            //Console.WriteLine(f(24, 12));
            //Testing((a, b) => a + b);
            //f += (a, b) => a * b;
            //Run((a, b) => {
            //    Thread.Sleep(2000);
            //    return a + b;
            //}, 12, 88);
            //Testing(f);
            //Console.WriteLine("Hello");
            //Console.ReadLine();
        }

        static void Run(Func<int, int, int> d, int a, int b)
        {
            Console.WriteLine(d(a, b));
        }
    }
}
