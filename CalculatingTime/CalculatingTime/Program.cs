using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            long time = DateTime.Now.Ticks;
            new Thread(() =>
            {
                for (long i = 0; i < 999999999; i++)
                {
                    //Console.WriteLine(i);
                }
                time = DateTime.Now.Ticks - time;
                Console.WriteLine(time);
            }).Start();
        }
    }
}
