using ProductLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        ProductDB db = new ProductDB();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private Product fromTxt()
        {
            try
            {
                int id = int.Parse(txtID.Text);
                if (id < 0) return null;
                string name = txtName.Text;
                if (name.Length == 0) return null;
                decimal price = decimal.Parse(txtPrice.Text);
                if (price < 0) return null;
                int quantity = int.Parse(txtQuantity.Text);
                if (quantity < 0) return null;
                return new Product(id, name, price, quantity);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void toTxt(Product product)
        {
            txtID.Text = product.ProductID + "";
            txtName.Text = product.ProductName;
            txtPrice.Text = product.UnitPrice + "";
            txtQuantity.Text = product.Quantity + "";
        }

        private void productGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void loadList()
        {
            productGrid.DataSource = db.GetProductList();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadList();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Product product = fromTxt();
            db.AddNewProduct(product);
            loadList();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            db.UpdateProduct(fromTxt());
            loadList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db.RemoveProduct(fromTxt());
            loadList();
        }

        private void productGrid_SelectionChanged(object sender, EventArgs e)
        {
            Product p = (Product)productGrid.CurrentRow.DataBoundItem;
            toTxt(p);
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtSearchID.Text, out id))
            {
                MessageBox.Show("Invalid ID");
                return;
            };
            Product p = db.FindProduct(id);
            if (p == null)
            {
                MessageBox.Show("No product found");
            } else
            {
                MessageBox.Show(p.ToString());
            }
        }
    }
}
