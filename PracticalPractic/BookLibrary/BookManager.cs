using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public class BookManager
    {
        public DataTable all()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Manager"].ConnectionString);
            string sql = "SELECT * FROM Books";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool add(Book book)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Manager"].ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "INSERT INTO Books VALUES(@BookID, @BookTitle, @BookPrice, @BookQuantity)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", book.BookID);
            cmd.Parameters.AddWithValue("@BookTitle", book.BookTitle);
            cmd.Parameters.AddWithValue("@BookPrice", book.BookPrice);
            cmd.Parameters.AddWithValue("@BookQuantity", book.BookQuantity);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }

        public bool update(Book book)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Manager"].ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "Update Books SET BookTitle = @BookTitle, BookPrice = @BookPrice, BookQuantity = @BookQuantity WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", book.BookID);
            cmd.Parameters.AddWithValue("@BookTitle", book.BookTitle);
            cmd.Parameters.AddWithValue("@BookPrice", book.BookPrice);
            cmd.Parameters.AddWithValue("@BookQuantity", book.BookQuantity);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }

        public bool delete(Book book)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Manager"].ConnectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "DELETE Books WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", book.BookID);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res > 0;
        }
    }

    public class Book
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public float BookPrice { get; set; }
        public int BookQuantity { get; set; }

        public static Book fromTextboxes(TextBox idTxt, TextBox titleTxt, TextBox priceTxt, TextBox quantityTxt, string parseError)
        {
            try
            {
                int id = int.Parse(idTxt.Text);
                string title = titleTxt.Text;
                float price = float.Parse(priceTxt.Text);
                int quantity = int.Parse(quantityTxt.Text);
                return new Book { BookID = id, BookTitle = title, BookPrice = price, BookQuantity = quantity};
            }
            catch (Exception)
            {
                MessageBox.Show(parseError);
                return null;
            }
        }
    }
}
