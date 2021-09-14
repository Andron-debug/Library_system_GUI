using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system_GUI
{
    [Serializable]
    class BookReader
    {
        private string Name;
        private int Year;
        private const int maxBook = 10;
        private List<Book> Books;
        public string name{ get { return Name; } }
        public int year { get { return Year; } }
        public List<Book> GetBooks()
        {
            return Books;     
        }
        public BookReader(string name, int  year)
        {
            Name = name;
            Year = year;
            Books = new List<Book>();
        }
        public bool TakeBook(Book bk)
        {
            if (Books.Count >= maxBook) return false;
            Books.Add(bk);
            return true;
        }
        public Book BookBack() 
        {
            if (Books.Count == 0) return null;
            Book bk = Books[0];
            Books.RemoveAt(0);
            return bk;
        }
        public Book BookBack(int id)
        {
            if (Books.Count == 0) return null;
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
        public List<Book> BackAll()
        {
            List<Book> bl;
            bl = new List<Book>();
            Book bk;
            while ((bk = BookBack()) != null) bl.Add(bk);
            return bl;
        }
        public override string ToString()
        {
            return "Читатель " + Name + " " + Year + " г." + "Книг на руках: " + Books.Count;
        }
    }
}
