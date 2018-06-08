using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Book
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int BookQuantity { get; set; }
        public double BookPrice { get; set; }

        public Book()
        {

        }

        public Book(int bookID, string bookTitle, int bookQuantity, double bookPrice)
        {
            BookID = bookID;
            BookTitle = bookTitle;
            BookQuantity = bookQuantity;
            BookPrice = bookPrice;
        }
    }
}
