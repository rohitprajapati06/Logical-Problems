/* 
Description: Design a Library class that contains a list of Book objects. A Book can exist independently of the Library.
*/

using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    
    public void DisplayBook()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}\n");
    }
}

class Library
{
    public string Name { get; set; }
    private List<Book> books = new List<Book>();
    
    public Library(string name)
    {
        Name = name;
    }
    
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    
    public void DisplayAllBooks()
    {
        Console.WriteLine($"Library: {Name}\n");
        Console.WriteLine("Books in library:");
        foreach (var book in books)
        {
            book.DisplayBook();
        }
    }
}

public class Program
{
    public static void Main()
    {
        Book book1 = new Book("Night Crawler", "David Fincher", "123-4567890");
        Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "987-6543210");
        
        Library library = new Library("Stanford");
        library.AddBook(book1);
        library.AddBook(book2);
        
        library.DisplayAllBooks();
    }
}
