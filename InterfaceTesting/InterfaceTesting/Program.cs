using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    interface IMath
    {
        //String Name { get; set; }
        int Add(int a, int b);
        void Print();
    }

    interface IYourMath
    {
        void Print();
    }

    class MyMath : IMath, IYourMath
    {
        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        void IMath.Print()
        {
            throw new NotImplementedException();
        }

        void IYourMath.Print()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            m.Add(2, 5);
            IMath im = m;
            im.Print();
            IYourMath y = m;
            y.Print();
        }
    }
}
