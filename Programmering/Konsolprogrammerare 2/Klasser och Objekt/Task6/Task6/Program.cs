using System;

namespace Task6
{
    class Book
    {
        protected string Title { get; set; }
        protected string Author { get; set; }
        protected int Pages { get; set; }
            
        protected string WriteBook
        {
            get { return "Title: " + Title + " | Author: " + Author + " | Pages: " + Pages; }
        }
    }
     class Program: Book
    {
        
        public static void Main(string[] args)
        {
            Program book = new Program();
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