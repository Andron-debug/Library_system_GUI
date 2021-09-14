using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_system_GUI
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        public int id { get { return Convert.ToInt32(textBox1.Text); } }
        public string name { get { return textBox2.Text; } }
        public string author { get { return textBox3.Text; } }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Заполните все поля");

        }
    }
}
