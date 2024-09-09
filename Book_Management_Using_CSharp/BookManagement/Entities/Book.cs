using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Entities
{
    public class Book
    {
        int id;
        string bookName;
        string authorName;
        string language;
        BookType booktype;
        BookGenres genre;

        public Book(int id, string bookName, string authorName, string language, BookType booktype, BookGenres genre)
        {
            this.Id = id;
            this.BookName = bookName;
            this.AuthorName = authorName;
            this.Language = language;
            this.Booktype = booktype;
            this.Genre = genre;
        }

        public int Id { get => id; set => id = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Language { get => language; set => language = value; }
        public BookType Booktype { get => booktype; set => booktype = value; }
        public BookGenres Genre { get => genre; set => genre = value; }

        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Book() { }
    }
}
