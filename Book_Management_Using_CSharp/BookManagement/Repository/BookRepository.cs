using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Repository
{
    public class BookRepository : IBookRepository
    {
        private List<Book> booklist;
        public BookRepository()
        {
            booklist = new List<Book>()
            {
                new Book() {Id=1,BookName="Chronicles of Celestia",AuthorName="Aurora Skyborne",Language="English",Booktype=BookType.General,Genre=BookGenres.Adventure},
                new Book() {Id=2,BookName="Cipher of Shadows",AuthorName="Victor Nocturne",Language="Spanish",Booktype=BookType.General,Genre=BookGenres.Mystery},
                new Book() {Id=3,BookName="The Interpretation of Dreams",AuthorName="Sigmund Freud  ",Language= "German",Booktype= BookType.Academic,Genre= BookGenres.Fiction},
                new Book() {Id=4,BookName="Moby-Dick",AuthorName="Herman Melville",Language="English",Booktype =BookType.Academic, Genre=BookGenres.Adventure}
            };
        }
        public Book AddBook(Book book)
        {
            Book newBook = ((from m in booklist orderby m.Id descending select m).Take(1)).Single() as Book;
            book.Id = newBook.Id + 1;
            booklist.Add(book);
            return book;
        }

        public Book DeleteBook(int id)
        {
            Book deleteBook = GetBook(id);
            if (deleteBook != null)
            {
                booklist.Remove(deleteBook);
            }
            return deleteBook;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return from rows in booklist select rows;
        }

        public Book GetBook(int id)
        {
            var books = (from e in booklist where e.Id == id select e).Single();
            return books;
        }

        public Book UpdateBook(Book updateBook)
        {
            Book book = GetBook(updateBook.Id);
            if (book != null)
            {
                book.Id = updateBook.Id;
                book.BookName = updateBook.BookName;
                book.AuthorName= updateBook.AuthorName;
                book.Language= updateBook.Language;
                book.Booktype= updateBook.Booktype;
                book.Genre= updateBook.Genre;
            }
            return book;
        }
    }
}
