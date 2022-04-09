using Classwork.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
     public  class Library
    {
        public int BookLimit { get; set; }

        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (books.Count<BookLimit)
            {
                books.Add(book);
            }
            else
            {
                throw new CapacityLimitException("Limit ashdiniz ...");
            }
        }

        public Book GetBookById(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("Null deyer daxil etmeyin");
            }
            foreach (var item in books)
            {
                if (item.Id==id)
                {
                    return item;
                }
            }
            return null;
        }

        public void RemoveById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null deyer daxil etmeyin");
            }
            foreach (var item in books)
            {

                if (item.Id== id)
                {
                    books.Remove(item);
                    return;
                }
            }
            throw new NotFoundException("Tapilmadi bu idli element");

        }
    }
}
