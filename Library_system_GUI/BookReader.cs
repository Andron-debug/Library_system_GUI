using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system_GUI
{
    class BookReader
    {
        public string Name;
        public int Year;
        public const int maxBook = 10;
        public List<Book> Books;
        
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
                if (Books[i].Id == id)
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
