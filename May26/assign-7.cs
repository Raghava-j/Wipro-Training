using System;
public abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}
public class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}.zip' using ZIP compression.");
    }
}
public class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}.rar' using RAR compression.");
    }
}
public class Compressor
{
    private CompressionStrategy _strategy;

    public Compressor(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }
    public void SetStrategy(CompressionStrategy strategy)
    {
        _strategy = strategy;
    }
    public void CompressFile(string inputPath, string outputPath)
    {
        _strategy.Compress(inputPath, outputPath);
    }
    
}
public class Program
{
    public static void Main()
    {
        CompressionStrategy zip = new ZipCompression();
        Compressor compressor = new Compressor(zip);
        compressor.CompressFile("report.docx", "report_compressed");

        CompressionStrategy rar = new RarCompression();
        compressor.SetStrategy(rar);
        compressor.CompressFile("presentation.ppt", "presentation_compressed");

    }
}