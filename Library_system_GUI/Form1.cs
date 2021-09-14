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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<BookReader> BookReaders = new List<BookReader>();
        private void Form1_Load(object sender, EventArgs e)
        {
            BookReaders = new List<BookReader>();
        }

        private void AddBookReader_Click(object sender, EventArgs e)
        {
            AddBR f = new AddBR();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BookReader br = new BookReader(f.name, f.year);
                BookReaderlistBox.Items.Add(f.name);
            }
        }
    }
}
