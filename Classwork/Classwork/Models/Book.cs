using Classwork.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string aurthorname, int pagecount, string name, double price) : base(name, price)
        {

            AuthorName = aurthorname;
            PageCount = pagecount;
        }
        public override void Sell()
        {
            if (Count>0)
            {
                Count--;
                TotalIncome += Price;
            }
            else
            {
                throw new ProductCountIsZeroException("Burada yeterli productumuz");
            }
            
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"Id - {Id} Name - {Name}  Count - {Count}  Price - {Price}  TotalIncome - {TotalIncome}");
        }
    }
}
