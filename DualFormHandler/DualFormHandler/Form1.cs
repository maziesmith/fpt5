using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualFormHandler
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            //form2.txtContent = this.txtContent;
            form2.Show();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            form2.txtContent.Text = this.txtContent.Text;
        }
    }
}
