using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookClient.localhost;

namespace BookClient
{
    public partial class Form1 : Form
    {
        BookService service = new BookService();

        public Form1()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            booksGrid.DataSource = service.getBooks().Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            service.addBook(int.Parse(txtBookID.Text), txtBookTitle.Text, float.Parse(txtBookPrice.Text));
            refresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            service.updateBook(int.Parse(txtBookID.Text), txtBookTitle.Text, float.Parse(txtBookPrice.Text));
            refresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            service.deleteBook(int.Parse(txtBookID.Text));
            refresh();
        }
    }
}
