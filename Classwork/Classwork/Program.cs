using Classwork.Exceptions;
using Classwork.Models;
using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("test-1", 120, "testov", 19.99);
            Book book2 = new Book("test-2", 320, "Tural", 49.99);
            Book book3 = new Book("test-3", 420, "Reshid", 59.99);

            Library library = new Library();
            library.BookLimit = 4;

            
            //Bu erroru Eli hell eledi.
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            book1.Count = 3;
            //book1.ShowInfo();
            //book2.ShowInfo();
            //book3.ShowInfo();
          
            try
            {
                //library.GetBookById(null);
                book1.Sell();
                book1.Sell();
                book1.Sell();
                book1.Sell();
                book1.Sell();
                book1.Sell();
                //library.RemoveById(null);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ProductCountIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
