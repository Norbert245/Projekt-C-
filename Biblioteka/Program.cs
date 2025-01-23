using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library("WZ Library");


            library.AddBook(new FictionBook("The Poppy War", "Rebecca F.Kuang", 2018, "Fantasy Fiction"));
            library.AddBook(new TechnicalBook("C# Programming", "Andrew Troelsen", 2017, "Programming"));
            library.AddBook(new Audiobook("Becoming", "Michelle Obama", 2018, "Narrator: Michelle Obama", 1140));
            library.AddBook(new Magazine("National Geographic", "January 2023", "Science & Nature"));

            library.AddUser(new LibraryUser("Norbert", "Handzlik", "12345"));
            library.AddUser(new LibraryUser("Mateusz", "Kowalczyk", "54321"));

            library.LoanBook("12345", "The Poppy War");

            library.DisplayLibraryDetails();
        }
            public void SaveToFile(string filePath)
        {
            var serializer = new XmlSerializer(typeof(Library), new Type[] { typeof(FictionBook), typeof(TechnicalBook), typeof(Audiobook), typeof(Magazine) });

            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }

            Console.WriteLine($"Library data saved to {filePath} (XML).");
        }
        public static Library LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return null!;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Library));
            using StreamReader reader = new StreamReader(filePath);

            object? result = serializer.Deserialize(reader);
            if (result is Library library)
            {
                return library;
            }
            else
            {
                throw new InvalidOperationException("Deserialization failed: Result is null or not a Library object.");
            }
        }



    }
}

