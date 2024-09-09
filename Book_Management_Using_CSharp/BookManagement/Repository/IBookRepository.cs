using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book>GetAllBooks();
        Book GetBook(int id);
        Book AddBook(Book book);
        Book UpdateBook(Book book);
        Book DeleteBook(int id);
    }
}
