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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void New_lib_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Upload_lib_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string lib = openFileDialog1.FileName;
                Form f = new Form1(lib);
                f.Show();
                this.Hide();
            }
            
        }
    }
}
