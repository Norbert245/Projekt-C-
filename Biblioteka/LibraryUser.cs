using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public LibraryUser(string firstName, string lastName, string cardNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
        }

        public void DisplayUserDetails()
        {
            Console.WriteLine($"User: {FirstName} {LastName}, Card: {CardNumber}");
            Console.WriteLine("Borrowed Books:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
}
