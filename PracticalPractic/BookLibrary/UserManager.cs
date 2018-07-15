using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public class UserManager
    {
        public bool login(string username, string password)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Manager"].ConnectionString);
            string sql = "SELECT * FROM UserInfo WHERE Username=@Username AND Password=@Password";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
