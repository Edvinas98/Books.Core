using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(int id, string title, string author, int year)
        {
            ID = id;
            Title = title;
            Author = author;
            Year = year;
        }
    }
}
