using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Library_system_GUI
{
    public partial class Form1 : Form
    {
        private List<BookReader> BookReaders = new List<BookReader>();
        private Depository dep;
        public Form1()
        {
            InitializeComponent();
            
            BookReaders = new List<BookReader>();
            

        }
        public Form1(string filename)
        {
            InitializeComponent();
            Stream s = File.OpenRead(filename);
            BinaryFormatter bf = new BinaryFormatter();
            BookReaders = (List<BookReader>)bf.Deserialize(s);
            dep = (Depository) bf.Deserialize(s);
            List_to_index(BooklistBox, dep.GetBooks());
            List_to_index(BookReaderlistBox, BookReaders);
            s.Close();
        }
        private void List_to_index(ListBox lbox, List<Book> bl)
        {
            lbox.Items.Clear();
            foreach (Book b in bl) lbox.Items.Add(b.id + " " + b.name);
        }
        private void List_to_index(ListBox lbox, List<BookReader> bl)
        {
            lbox.Items.Clear();
            foreach (BookReader b in bl) lbox.Items.Add(b.name);
        }

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
                BooklistBox.Items.Add(f.id+" "+f.author+" "+f.name);
            }

        }

        private void BookReaderlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookReader br = BookReaders[BookReaderlistBox.SelectedIndex];
            ReaderNameTextBox.Text = br.name;
            ReaderYearTextBox.Text = br.year.ToString();
            List_to_index(ReaderBooksListBox, br.GetBooks());
        }

        private void TakeBook_Click(object sender, EventArgs e)
        {
            BookReader br = BookReaders[BookReaderlistBox.SelectedIndex];
            Book bk = dep.GetBooks()[BooklistBox.SelectedIndex];
            if (br.TakeBook(bk)) MessageBox.Show("Книга взята");
            else MessageBox.Show("Лимит привышен");
            dep.GiveBook(bk.id);
            List_to_index(ReaderBooksListBox, br.GetBooks());
            List_to_index(BooklistBox, dep.GetBooks());
        }

        private void BookBack_Click(object sender, EventArgs e)
        {
            BookReader br = BookReaders[BookReaderlistBox.SelectedIndex];
            Book bk = br.GetBooks()[ReaderBooksListBox.SelectedIndex];
            br.BookBack(bk.id);
            dep.AcceptBook(bk);
            List_to_index(ReaderBooksListBox, br.GetBooks());
            List_to_index(BooklistBox, dep.GetBooks());
        }

        private void BackAll_Click(object sender, EventArgs e)
        {
            BookReader br = BookReaders[BookReaderlistBox.SelectedIndex];
            dep.AcceptBooks(br.BackAll());
            List_to_index(ReaderBooksListBox, br.GetBooks());
            List_to_index(BooklistBox, dep.GetBooks());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fn = "Test.test";
            BinaryFormatter bf = new BinaryFormatter();
            Stream s = File.Create(fn);
            bf.Serialize(s, BookReaders);
            bf.Serialize(s, dep);
            s.Close();
            Application.Exit();
        }
    }
}
