namespace StrategyPattern.ImageCompressor;
public class JPEGCompressor : IImageCompressor
{
    public void Compress(string fileName) =>
        Console.WriteLine($"Compressing JPEG: {fileName}");
}
