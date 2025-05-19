using System;
using System.Collections.Generic;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public Book(string title, string author)
    { Title = title;
        Author = author;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author : {Author}");
    }
}
class Program
{
    static void Main()
    {
        Queue<Book> borrowedBooks = new Queue<Book>();
        borrowedBooks.Enqueue(new Book("1984", "George Orwell"));
        borrowedBooks.Enqueue(new Book("To Kill a MockingBird", "Harper Lee"));
        borrowedBooks.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        borrowedBooks.Enqueue(new Book("Pride and Prejudice", "Jane Austen"));
        borrowedBooks.Enqueue(new Book("The Catcher in the Rye", "J.D Salinger"));

        Console.WriteLine("Next Book to be Returned:");
        borrowedBooks.Peek().Display();

        borrowedBooks.Dequeue();

        Console.WriteLine("\nRemaining Borrowed Books:");
        foreach (Book book in borrowedBooks)
        {
            book.Display();
        }
        Stack<Book> newBooks = new  Stack<Book>();
        newBooks.Push(new Book("Sapiens", "Yuval Noah Harari"));
        newBooks.Push(new Book("The Midnight Library", "Matt Haig"));
        newBooks.Push(new Book("Atomic Habits", "James Clear"));

        Console.WriteLine("\nLast Purchased Book:");
        newBooks.Peek().Display();
        newBooks.Pop();
        Console.WriteLine("\nRemaining New Books in Stack:");
        foreach(Book book in newBooks)
        {
            book.Display();
        }

    }
}