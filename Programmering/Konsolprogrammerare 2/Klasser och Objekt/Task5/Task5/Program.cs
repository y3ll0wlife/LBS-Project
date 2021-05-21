using System;

namespace Task5
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            
            public string WriteBook
            {
                get { return "Title: " + Title + " | Author: " + Author + " | Pages: " + Pages; }
            }
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
            Console.Write("Name of book: ");
            book.Title = Console.ReadLine();
            Console.Write("Author of the book: ");
            book.Author = Console.ReadLine();
            Console.Write("How many pages does the book have: ");
            book.Pages = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(book.WriteBook);
        }
    }
}