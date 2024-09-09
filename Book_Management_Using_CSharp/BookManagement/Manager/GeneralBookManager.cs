using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Manager
{
    internal class GeneralBookManager : IBookManager
    {

        public decimal GetPrice()
        {
            double price = 200;
            return (decimal)price;
        }

        public decimal GetDiscount()
        {
            double discount = .3;
            return (decimal)discount;
        }
    }
}
