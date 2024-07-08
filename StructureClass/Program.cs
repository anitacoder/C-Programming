using System;

namespace MakingStructures {
    struct Books {
        public string title;
        public string author;
        public string subject;
        public int book_id;
        public int totalNumberOfPages;
    }

    public class BookStructure {
        private Books Book1;
        private Books Book2;

        public BookStructure() {
            Book1.title = "Welcome to structure in C#";
            Book1.author = "Miss Anita";
            Book1.subject = "C# Structure";
            Book1.book_id = 663773;
            Book1.totalNumberOfPages = 0;

            Book2.title = "Life of Anita";
            Book2.author = "Miss Anita";
            Book2.subject = "Story Tale";
            Book2.book_id = 223551;
            Book2.totalNumberOfPages = 0;
        }

        public void DisplayBooks() {
            Console.WriteLine($"Book 1 Title: {Book1.title}");
            Console.WriteLine($"Book 1 Author: {Book1.author}");
            Console.WriteLine($"Book 1 Subject: {Book1.subject}");
            Console.WriteLine($"Book 1 Book ID: {Book1.book_id}");
            Console.WriteLine($"Book 1 Pages: {Book1.totalNumberOfPages}");
            Console.WriteLine();
            Console.WriteLine($"Book 2 Title: {Book2.title}");
            Console.WriteLine($"Book 2 Author: {Book2.author}");
            Console.WriteLine($"Book 2 Subject: {Book2.subject}");
            Console.WriteLine($"Book 2 Book ID: {Book2.book_id}");
            Console.WriteLine($"Book 2 Pages: {Book2.totalNumberOfPages}");
        }

        public void IncrementBook1Pages() {
            Book1.totalNumberOfPages++;
        }

        public void DecreaseBook2Pages() {
            Book2.totalNumberOfPages--;
        }
    }

    class Program {
        static void Main(string[] args) {
            BookStructure bookStructure = new BookStructure();
            bookStructure.DisplayBooks();

            bookStructure.IncrementBook1Pages();
            bookStructure.DecreaseBook2Pages();

            Console.WriteLine();
            Console.WriteLine("After modifying pages:");
            bookStructure.DisplayBooks();
        }
    }
}
