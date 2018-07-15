using BookLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalPractic
{
    public partial class ManageForm : Form
    {
        BookManager manager = new BookManager();

        public ManageForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            DataTable dt = manager.all();
            bookGrid.DataSource = dt;
            dt.Columns.Add(new DataColumn("Total", typeof(float), "BookPrice*BookQuantity"));
            bindingInput();
        }

        private void bindingInput()
        {
            bookIdTxt.DataBindings.Clear();
            bookTitleTxt.DataBindings.Clear();
            bookPriceTxt.DataBindings.Clear();
            bookQuantityTxt.DataBindings.Clear();
            bookIdTxt.DataBindings.Add(new Binding("text", bookGrid.DataSource, "BookID"));
            bookTitleTxt.DataBindings.Add(new Binding("text", bookGrid.DataSource, "BookTitle"));
            bookPriceTxt.DataBindings.Add(new Binding("text", bookGrid.DataSource, "BookPrice"));
            bookQuantityTxt.DataBindings.Add(new Binding("text", bookGrid.DataSource, "BookQuantity"));
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                manager.update(Book.fromTextboxes(bookIdTxt, bookTitleTxt, bookPriceTxt, bookQuantityTxt, "Invalid book information"));
                load();
            }
            catch (Exception)
            {
                MessageBox.Show("Error updating book!");
                throw;
            }
        }

        private void filterTxt_TextChanged(object sender, EventArgs e)
        {
            (bookGrid.DataSource as DataTable).DefaultView.RowFilter = "BookTitle LIKE '%" + filterTxt.Text + "%'";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                manager.add(Book.fromTextboxes(bookIdTxt, bookTitleTxt, bookPriceTxt, bookQuantityTxt, "Invalid book information"));
                load();
            }
            catch (Exception)
            {
                MessageBox.Show("Error adding book!");
                throw;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                manager.delete(Book.fromTextboxes(bookIdTxt, bookTitleTxt, bookPriceTxt, bookQuantityTxt, "Invalid book information"));
                load();
            }
            catch (Exception)
            {
                MessageBox.Show("Error deleting book!");
                throw;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
