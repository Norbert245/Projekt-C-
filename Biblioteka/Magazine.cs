using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Magazine : Book
    {
        public string Issue { get; set; }

        public Magazine(string title, string issue, string genre)
            : base(title, "Various Authors", 0)
        {
            Issue = issue;
        }
        public Magazine()
        {
            Issue = "Unknown";
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Magazine: {Title}, Issue: {Issue}, Available: {IsAvailable}");
        }
    }
}
