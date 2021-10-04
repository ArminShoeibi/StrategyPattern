namespace StrategyPattern.ImageCompressor;
public class PNGCompressor : IImageCompressor
{
    public void Compress(string fileName) =>
        Console.WriteLine($"Compressing PNG: {fileName}");
}
