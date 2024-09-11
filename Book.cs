using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolska_BookManager
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public int Volume { get; set; }

        public Book(string title, string author, string genre, string type, int year, int volume)
        {
            Author = author;
            Title = title;
            Genre = genre;
            Type = type;
            Year = year;
            Volume = volume;
        }
    }
}
