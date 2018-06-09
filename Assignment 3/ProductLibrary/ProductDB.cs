using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductLibrary
{
    public class ProductDB
    {
        private const string connectionString = "server=PHATNHSE63348\\SQLEXPRESS;database=SaleDB;uid=sa;pwd=hongphat";

        public bool AddNewProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Products VALUES(@id, @name, @quantity, @price)", con);
            cmd.Parameters.AddWithValue("@id", p.ProductID);
            cmd.Parameters.AddWithValue("@name", p.ProductName);
            cmd.Parameters.AddWithValue("@quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@price", p.UnitPrice);
            bool res = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return res;
        }

        public bool RemoveProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Products WHERE ProductID = @id", con);
            cmd.Parameters.AddWithValue("@id", p.ProductID);
            bool res = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return res;
        }

        public bool UpdateProduct(Product p)
        {
            if (p == null)
            {
                return false;
            }
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName=@name, UnitPrice=@price, Quantity=@quantity WHERE ProductID=@id", con);
            cmd.Parameters.AddWithValue("@id", p.ProductID);
            cmd.Parameters.AddWithValue("@name", p.ProductName);
            cmd.Parameters.AddWithValue("@quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@price", p.UnitPrice);
            bool res = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return res;
        }

        public Product FindProduct(int ProductID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE ProductID=@id", con);
            cmd.Parameters.AddWithValue("@id", ProductID);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    decimal price = dr.GetDecimal(2);
                    int quantity = dr.GetInt32(3);
                    return new Product(id, name, price, quantity);
                } else
                {
                    return null;
                }
            } else
            {
                return null;
            }
        }

        public List<Product> GetProductList()
        {
            List<Product> list = new List<Product>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    decimal price = dr.GetDecimal(2);
                    int quantity = dr.GetInt32(3);
                    list.Add(new Product(id, name, price, quantity));
                }
            }
            con.Close();
            return list;
        }

        public SqlDataAdapter fillGrid(DataGridView grid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            da.Fill(dt);
            con.Close();
            grid.DataSource = dt;
            return da;
        }
    }
}
