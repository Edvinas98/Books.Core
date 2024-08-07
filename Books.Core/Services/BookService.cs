using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Core.Contracts;
using Books.Core.Models;


namespace Books.Core.Services
{
    public class BookService : IBookService
    {
        private List<Book> Books = new List<Book>();

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBookById(int id)
        {
            foreach (Book b in Books)
            {
                if (b.ID == id)
                    return b;
            }
            return null;
        }

        public void AddBook(Book book)
        {
            bool bFound = false;

            foreach (Book b in Books)
            {
                if (b.ID == book.ID)
                    bFound = true;
            }

            if (!bFound)
                Books.Add(book);
        }

        public void RenewBook(Book book)
        {
            foreach (Book b in Books)
            {
                if (b.ID == book.ID)
                {
                    Books.Remove(b);
                    Books.Add(book);
                    break;
                }
            }
        }

        public void DeleteBook(Book book)
        {
            foreach (Book b in Books)
            {
                if (b.ID == book.ID)
                {
                    Books.Remove(b);
                    break;
                }
            }
        }
    }
}
