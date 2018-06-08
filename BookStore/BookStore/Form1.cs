using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        BookManager bm = new BookManager();
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            getAllBooks();
        }

        private void getAllBooks()
        {
            dt = bm.getBooks();
            bookGrid.DataSource = dt;
            bookIdTxt.DataBindings.Clear();
            bookTitleTxt.DataBindings.Clear();
            bookPriceTxt.DataBindings.Clear();
            bookQuantityTxt.DataBindings.Clear();
            bookIdTxt.DataBindings.Add("Text", dt, "BookID");
            bookTitleTxt.DataBindings.Add("Text", dt, "BookTitle");
            bookPriceTxt.DataBindings.Add("Text", dt, "BookPrice");
            bookQuantityTxt.DataBindings.Add("Text", dt, "BookQuantity");
        }

        private Book getBookFromTxt()
        {
            int id;
            string title;
            float price;
            int quantity;
            if (!int.TryParse(bookIdTxt.Text, out id))
            {
                return null;
            };
            title = bookTitleTxt.Text;
            if (!float.TryParse(bookPriceTxt.Text, out price))
            {
                return null;
            }
            if (!int.TryParse(bookQuantityTxt.Text, out quantity))
            {
                return null;
            };
            return new Book(id, title, quantity, price);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Book book = getBookFromTxt();
            if (bm.addNewBook(book))
            {
                MessageBox.Show("Add book successfully!");
                getAllBooks();
            } else
            {
                MessageBox.Show("Error adding book");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Book book = getBookFromTxt();
            if (bm.updateBook(book))
            {
                MessageBox.Show("Update book successfully!");
                getAllBooks();
            }
            else
            {
                MessageBox.Show("Error updating book");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Book book = getBookFromTxt();
            if (bm.deleteBook(book))
            {
                MessageBox.Show("Delete book successfully!");
                getAllBooks();
            }
            else
            {
                MessageBox.Show("Error deleting book");
            }
        }

        private void searchTitleTxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            string filter = $"BookTitle like '%{searchTitleTxt.Text}%'";
            dv.RowFilter = filter;
            totalLbl.Text = dt.Compute("SUM(BookQuantity)", filter) + "";
        }
    }
}
