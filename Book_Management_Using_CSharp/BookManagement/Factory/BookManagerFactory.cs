using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Factory
{
    public class BookManagerFactory
    {
        public BaseBookFactory CreateFactory(Book book)
        {
            BaseBookFactory returnValue = null;
            if (book.Booktype == BookType.Academic)
            {
                returnValue = new AcademicBookFactory(book);
            }
            else if (book.Booktype == BookType.General)
            {
                returnValue = new GeneralBookFactory(book);
            }
            return returnValue;
        }
    }
}
