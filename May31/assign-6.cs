using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsBorrowed { get; set; } = false;
    public Student BorrowedBy { get; set; }
    public DateTime? DueDate { get; set; }
}
class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
}
class Library
{
    private List<Book> books = new List<Book>();
    private List<Student> students = new List<Student>();
    public void AddBook(Book book) => books.Add(book);
    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book != null && !book.IsBorrowed)
        {
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' deleted.");
        }
        else
        {
            Console.WriteLine("Book not found or currently borrowed.");
        }
    }
    public void AddStudent(Student student) => students.Add(student);

    public void BorrowBook(int bookId, int studentId)
    {
        var book = books.FirstOrDefault(b => b.Id == bookId);
        var student = students.FirstOrDefault(s => s.StudentId == studentId);

        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }
        if (student == null)
        {
            Console.WriteLine("Student not found");
        }
        if (book.IsBorrowed)
        {
            Console.WriteLine("Book already borrowed");
            return;
        }
        book.IsBorrowed = true;
        book.BorrowedBy = student;
        book.DueDate = DateTime.Now.AddDays(14);

        Console.WriteLine($"'{book.Title}' borrowed by {student.Name}. Due on {book.DueDate.Value.ToShortDateString()}");
    }
    public void ShowBooks()
    {
        Console.WriteLine("\nAvailable Books:");
        foreach (var book in books)
        {
            string status = book.IsBorrowed
                ? $"Borrowed by {book.BorrowedBy.Name}, Due: {book.DueDate?.ToShortDateString()}"
                : "Available";
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Ststus: {status}");
        }
    }
}
class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddStudent(new Student { StudentId = 1, Name = "Bob" });
        library.AddStudent(new Student { StudentId = 2, Name = "Varma" });

        library.AddBook(new Book { Id = 101, Title = "C# Programming" });
        library.AddBook(new Book { Id = 102, Title = "Data Structures" });
        library.AddBook(new Book { Id = 103, Title = "Algorithms" });

        library.ShowBooks();
        library.BorrowBook(1001, 1);
        library.DeleteBook(101);
        library.DeleteBook(102);
        library.ShowBooks();
    }
}