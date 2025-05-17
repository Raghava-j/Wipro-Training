using System;
public abstract class Document
{
    public abstract void PrintContent();

    public void ShowDocumentType(string type)
    {
        Console.WriteLine($"Document Type: {type}");
    }
}
public class WordDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing Word Document");
    }
}
public class PDFDocument : Document
{
    public override void PrintContent()
    {
        Console.WriteLine("Printing PDF Document");
    }
}
class Program
{
    static void Main()
    {
        Document word = new WordDocument();
        Document pdf = new PDFDocument();

        word.ShowDocumentType("Word");
        word.PrintContent();

        pdf.ShowDocumentType("PDF");
        pdf.PrintContent();
    }
}