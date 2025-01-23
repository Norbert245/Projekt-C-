using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Loan
    {
        public Book Book { get; set; }
        public LibraryUser User { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan(Book book, LibraryUser user, DateTime loanDate, DateTime returnDate)
        {
            Book = book;
            User = user;
            LoanDate = loanDate;
            ReturnDate = returnDate;
        }

        public void DisplayLoanDetails()
        {
            Console.WriteLine($"Loan: {Book.Title} borrowed by {User.FirstName} {User.LastName} on {LoanDate.ToShortDateString()} due by {ReturnDate.ToShortDateString()}");
        }
    }
}
