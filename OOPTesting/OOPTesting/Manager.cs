using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTesting
{
    partial class Manager : Employee
    {
        public int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //public Manager() { }

        //public Manager(int id, string name, int age) : base(id, name)
        //{
        //    this.Age = age;
        //}

        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Age: {Age}");
        //}
    }
}
