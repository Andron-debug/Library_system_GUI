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
            BookReaders = new List<BookReader>();
            dep = new Depository();
        }
        private void List_to_index(ListBox lbox, List<Book> bl)
        {
            lbox.Items.Clear();
            foreach (Book b in bl) lbox.Items.Add(b.id + " " + b.name);
        }
        private List<BookReader> BookReaders = new List<BookReader>();
        private Depository dep;
        private void Form1_Load(object sender, EventArgs e)
        {
            BookReaders = new List<BookReader>();
            dep = new Depository();
        }

        private void AddBookReader_Click(object sender, EventArgs e)
        {
            AddBR f = new AddBR();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BookReader br = new BookReader(f.name, f.year);
                BookReaders.Add(br);
                BookReaderlistBox.Items.Add(f.name);
            }
        }

        private void AddBk_Click(object sender, EventArgs e)
        {
            AddBook f = new AddBook();
            if(f.ShowDialog() == DialogResult.OK)
            {
                Book bk = new Book(f.id, f.author, f.name);
                dep.AcceptBook(bk);
                BooklistBox.Items.Add(f.id+" "+f.Name);
            }

        }

        private void BookReaderlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookReader br = BookReaders[BookReaderlistBox.SelectedIndex];
            ReaderNameTextBox.Text = br.name;
            ReaderYearTextBox.Text = br.year.ToString();
            List_to_index(ReaderBooksListBox, br.GetBooks());
        }
    }
}
