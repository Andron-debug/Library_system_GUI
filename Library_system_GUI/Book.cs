using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system_GUI
{
    class Book
    {
        public int Id;
        public string Author;
        public string Name;
        public Book(int id, string author, string name)
        {
            Id = id;
            Author = author;
            Name = name;
        }
        public override string ToString()
        {
            return "Книга. ID: " + Id + " Автор: " + Author + " Название: " + Name;
        }
    }
}
