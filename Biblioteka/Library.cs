using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public List<LibraryUser> Users { get; set; } = new List<LibraryUser>();
        public List<Loan> Loans { get; set; } = new List<Loan>();

        public Library(string name)
        {
            Name = name;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddUser(LibraryUser user)
        {
            Users.Add(user);
        }

        public void LoanBook(string cardNumber, string bookTitle)
        {
            var user = Users.FirstOrDefault(u => u.CardNumber == cardNumber);
            var book = Books.FirstOrDefault(b => b.Title == bookTitle && b.IsAvailable);

            if (user == null || book == null)
            {
                Console.WriteLine("Loan failed: User or book not found, or book not available.");
                return;
            }

            book.IsAvailable = false;
            user.BorrowedBooks.Add(book);
            Loans.Add(new Loan(book, user, DateTime.Now, DateTime.Now.AddDays(14)));
            Console.WriteLine($"Book '{book.Title}' loaned to {user.FirstName} {user.LastName}.");
        }

        public void DisplayLibraryDetails()
        {
            Console.WriteLine($"Library: {Name}");
            Console.WriteLine("Books:");
            foreach (var book in Books)
            {
                book.DisplayDetails();
            }

            Console.WriteLine("Users:");
            foreach (var user in Users)
            {
                user.DisplayUserDetails();
            }

            Console.WriteLine("Loans:");
            foreach (var loan in Loans)
            {
                loan.DisplayLoanDetails();
            }
        }
    }
}
