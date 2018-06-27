using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestingNUnit
{
    class Program
    {
        public int DayInMonth(int month, int year)
        {
            if (month < 1 || month > 12 || year < 1000 || year > 3000)
            {
                return 0;
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            if (DateTime.IsLeapYear(year))
            {
                return 29;
            } else
            {
                return 28;
            }
        }

        public bool IsValidDate(int day, int month, int year)
        {
            if (day < 1 || month < 1 || month > 12 || year < 1000 || year > 3000)
            {
                return false;
            }
            int dim = DayInMonth(month, year);
            if (day > dim)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
