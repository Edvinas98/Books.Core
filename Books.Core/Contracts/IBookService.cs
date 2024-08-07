using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Core.Models;

namespace Books.Core.Contracts
{
    public interface IBookService
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);

        void AddBook(Book book);

        void RenewBook(Book book);

        void DeleteBook(Book book);
    }
}
