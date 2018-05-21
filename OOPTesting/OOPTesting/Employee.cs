using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTesting
{
    partial class Employee
    {
        private int empID;

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        private string empName;

        public string FullName
        {
            get { return empName; }
            set { empName = value; }
        }

        public Employee()
        {
            ID = 0;
            FullName = string.Empty;
        }

        public Employee(int id, string name)
        {
            ID = id;
            FullName = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"ID: {ID}, Name: {FullName}");
        }
    }
}
