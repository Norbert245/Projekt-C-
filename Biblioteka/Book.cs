using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Library
{
    using System.Xml.Serialization;

    [XmlInclude(typeof(FictionBook))]
    [XmlInclude(typeof(TechnicalBook))]
    [XmlInclude(typeof(Audiobook))]
    [XmlInclude(typeof(Magazine))]

    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author, int year) 
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public Book() 
        {
            Title = "Unknown";
            Author = "Unkown";
        }
        public abstract void DisplayDetails();
    }
}
