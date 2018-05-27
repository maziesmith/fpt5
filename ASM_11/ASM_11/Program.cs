using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_11
{
    public delegate void WarningEvent(string msg);

    class Program
    {
        public static int toInt(string s)
        {
            int x;
            bool c = int.TryParse(s, out x);
            return c ? x : 0;
        }

        static void Main(string[] args)
        {
            Product caphe = new Product{ ProductID=1, ProductName="Ca Phe", Quantity=3, UnitPrice=12.5f };
            Product banhbao = new Product{ ProductID=2, ProductName="Banh Bao", Quantity=12, UnitPrice=8f };
            ManageProduct mp = new ManageProduct();
            mp.OnProductRemoved += Mp_OnProductRemoved;
            mp.AddNew(caphe);
            mp.AddNew(banhbao);
            mp.Show();
            Console.WriteLine("Nhap san pham can tim: ");
            int productID = toInt(Console.ReadLine());
            Console.WriteLine(mp.Find(productID));
            Console.WriteLine("Nhap san pham can xoa: ");
            productID = toInt(Console.ReadLine());
            mp.Remove(productID);
            Console.WriteLine("Sau khi xoa: ");
            mp.Show();
        }

        private static void Mp_OnProductRemoved(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
