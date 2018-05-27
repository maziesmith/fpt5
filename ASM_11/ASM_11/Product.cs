using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_11
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float SubTotal
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }

        public Product() {}

        public Product(int productID, string productName, int quantity, float unitPrice)
        {
            ProductID = productID;
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
                return $"{ProductID, 10} | {ProductName, 30} | {Quantity, 10} | {UnitPrice, 10}";
        }
    }
}
