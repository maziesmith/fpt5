using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_6
{
    class Medicine
    {
        private string code;
        private string name;
        private string manufacturer;
        private int price;
        private int quantity;
        private string date;
        private string expireDate;
        private int batchNumber;

        public Medicine() { }

        public Medicine(string code, string name, string manufacturer, int price, int quantity, string date, string expireDate, int batchNumber)
        {
            this.code = code;
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.quantity = quantity;
            this.date = date;
            this.expireDate = expireDate;
            this.batchNumber = batchNumber;
        }

        private int readInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        private string readString(string message)
        {
            Console.Write(message);
            string res;
            do
            {
                res = Console.ReadLine();
            } while (res == null);
            return res;
        }

        public void Accept()
        {
            code = readString("Enter the medicine code: ");
            name = readString("Enter the medicine name: ");
            manufacturer = readString("Enter the manufacturer name: ");
            price = readInt("Enter the unit price: ");
            quantity = readInt("Enter the quantity on hand: ");
            date = readString("Enter the manufactured date: ");
            expireDate = readString("Enter the expired date: ");
            batchNumber = readInt("Enter batch number: ");
        }

        public void IncreaseQuantity()
        {
            quantity += 50;
        }

        public void Print()
        {
            Console.WriteLine("************** Medicine Detail **************");
            Console.WriteLine($"Medicine code: {code}");
            Console.WriteLine($"Medicine name: {name}");
            Console.WriteLine($"Manufacturer name: {manufacturer}");
            Console.WriteLine($"The unit price: {price}");
            Console.WriteLine($"Quantity on hand: {quantity}");
            Console.WriteLine($"Manufactured date: {date}");
            Console.WriteLine($"The expiry date: {expireDate}");
            Console.WriteLine($"Batch number: {batchNumber}");
        }

        public void Print(string code)
        {
            Console.WriteLine("The medicine code: " + code);
            Console.WriteLine("The quantity on hand: " + quantity);
        }

        public void Print(string code, string name)
        {
            Console.WriteLine("The medicine code: " + code);
            Console.WriteLine("The medicine name: " + name);
            Console.WriteLine($"The expiry date: {expireDate}");
            Console.WriteLine($"Manufactured date: {date}");
        }
    }
}
