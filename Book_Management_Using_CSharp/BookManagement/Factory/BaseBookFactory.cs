using BookManagement.Entities;
using BookManagement.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Factory
{
    public abstract class BaseBookFactory
    {
        protected Book _book;
        protected BaseBookFactory(Book book)
        {
            _book = book;
        }
        public abstract IBookManager Create();
        public Book PriceAndDiscount()
        {
            IBookManager manager = this.Create();
            _book.Price =manager.GetPrice();
            return _book;
        }
    }
}
