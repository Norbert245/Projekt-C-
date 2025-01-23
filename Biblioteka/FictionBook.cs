using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class FictionBook : Book
    {
        public string Genre { get; set; }

        public FictionBook(string title, string author, int year, string genre)
            : base(title, author, year)
        {
            Genre = genre;
        }
        public FictionBook() 
        {
            Genre = "Unkown";
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Fiction Book: {Title}, Author: {Author}, Year: {Year}, Genre: {Genre}, Available: {IsAvailable}");
        }
    }
}
