using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnFirst.Click += BtnClick;
            btnSecond.Click += BtnClick;
        }

        private void BtnClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Nut so {(sender as Button).Text} duoc nhan");
        }

        private void BtnSecond_Click(object sender, EventArgs e)
        {
            
        }
    }
}
