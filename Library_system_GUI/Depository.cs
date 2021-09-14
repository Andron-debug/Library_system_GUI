using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system_GUI
{
    class Depository
    {
        private List<Book> Books;
        public List<Book> books
        {
            get
            {
                List<Book> bl = new List<Book>(Books);
                return bl;
            }
        }
        public Depository()
        {
            Books = new List<Book>();
        }
        public Book GiveBook(int id)
        {
            for (int i = 0; i<Books.Count; i++)
            {
                if (Books[i].id == id)
                {
                    Book bk = Books[i];
                    Books.RemoveAt(i);
                    return bk;
                }
            }
            return null;
        }
        public void AcceptBook(Book book)
        {
            Books.Add(book);
        }
        public void AcceptBooks(List<Book> booklist)
        {
            Books.AddRange(booklist);
        }
    }
}
