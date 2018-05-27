using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_11
{
    class ManageProduct
    {
        public event WarningEvent OnProductRemoved;

        public ArrayList list = new ArrayList();
        
        public void AddNew(Product p)
        {
            list.Add(p);
        }

        public void Show()
        {
            Console.WriteLine("All product in system:");
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public Product Find(int productID)
        {
            foreach (Product p in list)
            {
                if (p.ProductID == productID)
                {
                    return p;
                }
            }
            return null;
        }

        public void Remove(int productID)
        {
            Product p = Find(productID);
            if (p != null)
            {
                list.Remove(p);
                OnProductRemoved($"Product {productID} removed successfully!");
            } else
            {
                OnProductRemoved("This product is not exist in system!");
            }
        }
    }
}
