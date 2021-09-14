using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system_GUI
{
    class Book
    {
        private int Id;
        private string Author;
        private string Name;
        public int id { get { return Id; } }
        public string author { get { return Author; } }
        public string name { get { return Name; } }
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
