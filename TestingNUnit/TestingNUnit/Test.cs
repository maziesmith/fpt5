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
            Assert.AreEqual(31, p.DayInMonth(1, 2012));
            Assert.AreEqual(31, p.DayInMonth(1, 2013));
            Assert.AreEqual(29, p.DayInMonth(2, 2000));
            Assert.AreEqual(29, p.DayInMonth(2, 2012));
            Assert.AreEqual(28, p.DayInMonth(2, 2013));
            Assert.AreEqual(31, p.DayInMonth(3, 2000));
            Assert.AreEqual(31, p.DayInMonth(3, 2012));
            Assert.AreEqual(31, p.DayInMonth(3, 2013));
            Assert.AreEqual(0, p.DayInMonth(0, 2000));
            Assert.AreEqual(0, p.DayInMonth(0, 2012));
            Assert.AreEqual(0, p.DayInMonth(0, 2013));
            Assert.AreEqual(0, p.DayInMonth(13, 2000));
            Assert.AreEqual(0, p.DayInMonth(13, 2012));
            Assert.AreEqual(0, p.DayInMonth(13, 2013));
        }

        [Test]
        public void CheckIsValidDate()
        {
            Program p = new Program();
            Assert.AreEqual(true, p.IsValidDate(29, 2, 2000));
            Assert.AreEqual(true, p.IsValidDate(29, 3, 2009));
            Assert.AreEqual(true, p.IsValidDate(29, 4, 2000));
            Assert.AreEqual(false, p.IsValidDate(29, 2, 2009));
            Assert.AreEqual(false, p.IsValidDate(30, 2, 2000));
            Assert.AreEqual(true, p.IsValidDate(30, 3, 2009));
            Assert.AreEqual(true, p.IsValidDate(30, 4, 2009));
            Assert.AreEqual(true, p.IsValidDate(30, 3, 2000));
            Assert.AreEqual(false, p.IsValidDate(31, 4, 2000));
            Assert.AreEqual(true, p.IsValidDate(31, 3, 2000));
            Assert.AreEqual(false, p.IsValidDate(31, 4, 2009));
            Assert.AreEqual(false, p.IsValidDate(31, 2, 2000));
            Assert.AreEqual(true, p.IsValidDate(31, 3, 2009));
            Assert.AreEqual(false, p.IsValidDate(31, 4, 2000));
            Assert.AreEqual(true, p.IsValidDate(31, 3, 2009));
        }
    }
}
