using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class BookManager
    {
        string connectionString {
            get
            {
                return "server=PHATNHSE63348\\SQLEXPRESS;database=Manager;uid=sa;pwd=hongphat";
            }
        }

        public BookManager() {}

        public DataTable getBooks()
        {
            string sql = "select * from Books";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBook = new DataTable();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da.Fill(dtBook);
            }
            catch (SqlException se)
            {
                throw;
            } finally
            {
                con.Close();
            }
            return dtBook;
        }

        public bool addNewBook(Book book)
        {
            string sql = "AddBook";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", book.BookID);
            cmd.Parameters.AddWithValue("@title", book.BookTitle);
            cmd.Parameters.AddWithValue("@quantity", book.BookQuantity);
            cmd.Parameters.AddWithValue("@price", book.BookPrice);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }
        
        public bool updateBook(Book book)
        {
            string sql = "update Books set BookTitle=@title, BookQuantity=@quantity, BookPrice=@price where BookID=@id";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", book.BookID);
            cmd.Parameters.AddWithValue("@title", book.BookTitle);
            cmd.Parameters.AddWithValue("@quantity", book.BookQuantity);
            cmd.Parameters.AddWithValue("@price", book.BookPrice);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return count > 0;
        }

        public bool deleteBook(Book book)
        {
            string sql = "delete Books where BookID=@id";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", book.BookID);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
