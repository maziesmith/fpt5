using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyMath
    {
        public int x;
        public static int y;
        public static int z;

        public MyMath()
        {
            x = 1;
            Console.WriteLine("Object Constructor");
        }
        static MyMath()
        {
            y = 2;
            Console.WriteLine("Static constructor");
        }

        /// <summary>
        /// Add two numbers method
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">Second number</param>
        /// <returns></returns>
        public static int Add(int a, int b) => a + b;
    }
}
