//Library System with Aggregation and Search
using System;
using System.Collections.Generic;
using System.Linq;
class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }
    public override string ToString() => $"{Title} by {Author} (Available: {IsAvailable})";
}
class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public List<Book> SearchByAuthor(string author)
    {
        return books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
    public List<Book> SearchByTitle(string title)
    {
        return books
            .Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
class Program
{
    static void Main()
    {
        var library = new Library();
        library.AddBook(new Book { Id = 1, Title = "C# in Depth", Author = "john Skeet", IsAvailable = true });
        library.AddBook(new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", IsAvailable = false });
        library.AddBook(new Book { Id = 3, Title = "Clean Code", Author = "Robert C. Martin", IsAvailable = true });
        library.AddBook(new Book { Id = 4, Title = "C# Programming", Author = "john Sharp", IsAvailable = true });

        Console.WriteLine("Search by Author: 'Martin'");
        var authorResults = library.SearchByAuthor("Martin");
        foreach (var book in authorResults)
            Console.WriteLine(book);
        Console.WriteLine();

        Console.WriteLine("Search by Title: C#");
        var titleResults = library.SearchByTitle("C#");
        foreach (var book in titleResults)
            Console.WriteLine(book);
    }
}