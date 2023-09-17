using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Library
    {
        private readonly List<Book> books = new();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public IEnumerable<Book> GetOrderByAuthorIterator()
        {
            foreach (var book in books.OrderBy(book => book.Author))
            {
                yield return book;
            }
        }

        public IEnumerable<Book> GetOrderTitleIterator()
        {
            foreach (var book in books.OrderBy(book => book.Title))
            {
                yield return book;
            }
        }

        public IEnumerable<Book> GetOrderByYearIterator()
        {
            foreach (var book in books.OrderBy(book => book.Year))
            {
                yield return book;
            }
        }
    }
}
