using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithLabelsAndTextBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(phoneTxt.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<dynamic> itemsList = new List<dynamic>
            {
                new { ID = 1, Name = "Coffee" },
                new { ID = 2, Name = "Mocha" },
                new { ID = 3, Name = "Matcha" },
                new { ID = 4, Name = "Tra da" },
            };
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = itemsList;
            dataGridView1.DataSource = itemsList;
        }
    }
}
