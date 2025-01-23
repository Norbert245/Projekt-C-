using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Audiobook : Book
    {
        public string Narrator { get; set; }
        public int DurationInMinutes { get; set; }

        public Audiobook(string title, string author, int year, string narrator, int durationInMinutes)
            : base(title, author, year)
        {
            Narrator = narrator;
            DurationInMinutes = durationInMinutes;
        }
        public Audiobook() 
        {
            Narrator = "Unkown";
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Audiobook: {Title}, Author: {Author}, Year: {Year}, Narrator: {Narrator}, Duration: {DurationInMinutes} minutes, Available: {IsAvailable}");
        }
    }
}
