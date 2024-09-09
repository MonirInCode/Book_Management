using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Manager
{
    public class AcademicBookManager : IBookManager
    {

        public decimal GetPrice()
        {
            double price = 350;
            return (decimal)price;
        }

        public string Gift()
        {
            string gift = "20 Tk Coupon";
            return gift;
        }
    }
}
