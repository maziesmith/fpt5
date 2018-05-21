using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee { ID = 12, FullName = "Nguyen Hong Phat" };
            //e.Print();

            //Manager m = new Manager(3, "Hong Phat", 5);
            //m.Print();

            Manager mp = new Manager { ID = 4, FullName = "Hello", Age = 60};
            //mp.Print();

            e = mp;
            e.AddOn();
            e.Print();
        }
    }
}
