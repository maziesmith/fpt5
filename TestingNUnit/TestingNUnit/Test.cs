using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingNUnit
{
    [TestFixture]
    class Test
    {
        [Test]
        public void CheckDayInMonth()
        {

            Program p = new Program();
            Assert.AreEqual(31, p.DayInMonth(1, 2000));
            Assert.AreEqual(0, p.DayInMonth(2, 999));
            Assert.AreEqual(31, p.DayInMonth(3, 2031));
            Assert.AreEqual(31, p.DayInMonth(2, 2000));
            Assert.AreEqual(31, p.DayInMonth(0, 2000));
            Assert.AreEqual(29, p.DayInMonth(12, 2000));
            Assert.AreEqual(29, p.DayInMonth(2, 2016));
            Assert.AreEqual(29, p.DayInMonth(2, 2008));
            Assert.AreEqual(29, p.DayInMonth(2, 2012));
            Assert.AreEqual(29, p.DayInMonth(2, 3000));
        }

        [Test]
        public void CheckIsValidDate()
        {
            Program p = new Program();
            Assert.AreEqual(true, p.IsValidDate(10, 0, 1000));
            Assert.AreEqual(false, p.IsValidDate(28, 12, 2000));
            Assert.AreEqual(true, p.IsValidDate(31, 12, 2012));
            Assert.AreEqual(false, p.IsValidDate(29, 2, 2002));
            Assert.AreEqual(true, p.IsValidDate(32, 1, 2010));
            Assert.AreEqual(false, p.IsValidDate(29, 2, 2010));
            Assert.AreEqual(false, p.IsValidDate(29, 2, 2011));
            Assert.AreEqual(true, p.IsValidDate(29, 2, 2011));
            Assert.AreEqual(false, p.IsValidDate(29, 2, 2016));
            Assert.AreEqual(true, p.IsValidDate(28, 2, 2018));
            Assert.AreEqual(false, p.IsValidDate(29, 2, 2000));
        }
    }
}
