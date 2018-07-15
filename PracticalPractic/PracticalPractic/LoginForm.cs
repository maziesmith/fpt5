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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserManager usermanager = new UserManager();
            bool res = usermanager.login(usernameTxt.Text, passwordTxt.Text);
            if (res)
            {
                this.Hide();
                new ManageForm().ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Incorrect username or password!");
            }
        }
    }
}
