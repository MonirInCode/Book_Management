using BookManagement.Entities;
using BookManagement.Factory;
using BookManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class Program
    {
        public static BookRepository repo = new BookRepository();
        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {           
            Console.WriteLine("\t\t\t\tName : Md.Moniruzzaman Monir\r");
            Console.WriteLine("\t\t\t\tTraineeId : 1280429\r");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t=====Project of BookShop=====\r");
            Console.WriteLine("\t\t\t\t-----------------------------\n");
            Console.WriteLine("\t\tHow many operation would you like to perform?\n");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\t\t\t\tSelect Operation\n");
                    Console.WriteLine("\t\tHint: Select -1|Add -2|Update -3|Delete -4");
                    int opeCount = Convert.ToInt32(Console.ReadLine());
                    switch (opeCount)
                    {
                        case 1: GetAllBooks(null); break;
                        case 2: AddBook(); break;
                        case 3: UpdateBook(); break;
                        case 4: DeleteBook(); break;
                    }
                }
            }
        }

        private static void DeleteBook()
        {
            Console.WriteLine("Enter Book Id");
            int id=Convert.ToInt32(Console.ReadLine());
            Book deleteBook = new Book();
            deleteBook.Id = id;
            deleteBook = repo.GetBook(deleteBook.Id);

            Console.WriteLine("Book Deleted Successfully");
            GetAllBooks(deleteBook);
        }

        private static void UpdateBook()
        {
            Console.WriteLine("Enter Book Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Name");
            string bName=Console.ReadLine();
            Console.WriteLine("Enter Author Name");
            string aName=Console.ReadLine();
            Console.WriteLine("Enter Language");
            string language=Console.ReadLine();
        EnterBookType:
            Console.WriteLine("Enter Book Type *Hint: Academic=1, General=2");
            string typeRead = Console.ReadLine();
            BookType bookType;
            try
            {
                bookType = (BookType)Enum.Parse(typeof(BookType), typeRead);
            }
            catch
            {
                Console.WriteLine("Invalid type!!! Try Again");
                goto EnterBookType;
            }

        EnterBookGenre:
            Console.WriteLine("Enter Book Genre *Hint: Fiction=1, Mystery=2, Thriller=3, Romance=4, ScienceFiction=5, Biography=6, Adventure=7");
            string genreRead = Console.ReadLine();
            BookGenres bookGenre;
            try
            {
                bookGenre = (BookGenres)Enum.Parse(typeof(BookGenres), genreRead);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterBookGenre;
            }
            Book upBook = new Book();
            upBook.Id = id;
            upBook.BookName = bName;
            upBook.AuthorName= aName;
            upBook.Language = language;
            upBook.Booktype = bookType;
            upBook.Genre = bookGenre;
            upBook = repo.UpdateBook(upBook);
            Console.WriteLine("Book Update Successfully");
            GetAllBooks(upBook);
        }

        private static void AddBook()
        {
            Console.WriteLine("Enter Book Name");
            string bookName=Console.ReadLine();
            Console.WriteLine("Enter AuthorName");
            string authorName=Console.ReadLine();
            Console.WriteLine("Enter Book Language");
            string language=Console.ReadLine();
        EnterBookType:
            Console.WriteLine("Enter Book Type *Hint: Academic=1, General=2");
            string typeRead = Console.ReadLine();
            BookType bookType;
            try
            {
                bookType = (BookType)Enum.Parse(typeof(BookType), typeRead);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterBookType;
            }

        EnterBookGenre:
            Console.WriteLine("Enter Book Genre *Hint: Fiction=1, Mystery=2, Thriller=3, Romance=4, ScienceFiction=5, Biography=6, Adventure=7");
            string genreRead = Console.ReadLine();
            BookGenres bookGenre;
            try
            {
                bookGenre = (BookGenres)Enum.Parse(typeof(BookGenres), genreRead);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterBookGenre;
            }
            Book book = new Book(0,bookName, authorName, language, bookType, bookGenre);
            BaseBookFactory bookFactory = new BookManagerFactory().CreateFactory(book);
            bookFactory.PriceAndDiscount();
            repo.AddBook(book);
            Console.WriteLine("Book Add Successfully");
            GetAllBooks(book);
        }

        private static void GetAllBooks(Book book)
        {
            IEnumerable<Book> books = repo.GetAllBooks();
            Console.WriteLine(string.Format("|{0,5}| {1,35}| {2,-15}| {3,12}| {4,12}| {5,15}|", "ID", "BookName", "     AuthorName" ,"Language","BookType","Genre"));
            Console.WriteLine();
            if (book == null)
            {
                foreach (Book item in books)
                {
                    Console.WriteLine(string.Format("|{0,5}| {1,35}| {2,-15}| {3,12}| {4,12}| {5,15}|",
                        item.Id, item.BookName, item.AuthorName, item.Language,item.Booktype,item.Genre));
                }
            }
            else
            {
                Console.WriteLine(string.Format("|{0,5}| {1,35}| {2,-15}| {3,12}| {4,12}| {5,15}|",
                    book.Id, book.BookName, book.AuthorName, book.Language,book.Booktype,book.Genre));
            }
            Console.WriteLine();
        }
    }
}
