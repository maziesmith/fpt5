using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise
{
    class Program
    {
        public static int NhapSo()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int BinhPhuong(int a)
        {
            return a * a;
        }

        public static float CanBac2(int a)
        {
            return (float)Math.Sqrt(a);
        }

        delegate int A();
        delegate int B(int x);
        delegate float C(int x);

        static void Main(string[] args)
        {
            B b = BinhPhuong;
            Console.WriteLine(b(new A(NhapSo)()));
            Console.WriteLine(new C(CanBac2)(8));
            b = delegate (int a)
            {
                return a * a * a;
            };
            Console.WriteLine(b(2));
            b = (a) => a * a * a * a;
            Console.WriteLine(b(2));
        }
    }
}
