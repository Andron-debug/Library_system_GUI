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

    public partial class AddBR : Form
    {
        public AddBR()
        {
            InitializeComponent();
        }
        public string name {get
            {
                return textBox1.Text;
            }
        }
        public int year
        {
            get
            {
                return Convert.ToInt32(textBox2.Text);
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            
            if((textBox1.Text!="")&&(textBox2.Text !=""))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
    }
}
