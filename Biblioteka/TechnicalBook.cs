using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TechnicalBook : Book
    {
        public string Field { get; set; }

        public TechnicalBook(string title, string author, int year, string field)
            : base(title, author, year)
        {
            Field = field;
        }
        public TechnicalBook() 
        {
            Field = "Unknown";
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Technical Book: {Title}, Author: {Author}, Year: {Year}, Field: {Field}, Available: {IsAvailable}");
        }
    }
}
