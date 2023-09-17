using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Book
    {
        public Book(string author, string title, DateTime year)
        {
            Author = author;
            Title = title;
            Year = year;
        }

        public string Author { get; set; }

        public string Title { get; set; }

        public DateTime Year { get; set; }
    }
}
