ImageStorage imageStorage = new(new PNGCompressor(), new BlackAndWhiteFilter());
imageStorage.Store("me.png");

class ImageStorage
{
    private readonly IImageCompressor _imageCompressor;
    private readonly IImageFilter _imageFilter;
    public ImageStorage(IImageCompressor imageCompressor, IImageFilter imageFilter)
    {
        _imageCompressor = imageCompressor;
        _imageFilter = imageFilter;
    }

    public void Store(string fileName)
    {
        _imageCompressor.Compress(fileName);
        _imageFilter.Apply(fileName);
    }
}


interface IImageFilter
{
    void Apply(string fileName);
}
class BlackAndWhiteFilter : IImageFilter
{
    public void Apply(string fileName) => Console.WriteLine("Applying B&W Filter");
}


interface IImageCompressor
{
    void Compress(string fileName);
}

class JPEGCompressor : IImageCompressor
{
    public void Compress(string fileName) => Console.WriteLine($"Compressing JPEG: {fileName}");
}

class PNGCompressor : IImageCompressor
{
    public void Compress(string fileName) => Console.WriteLine($"Compressing PNG: {fileName}");
}

class GIFCompressor : IImageCompressor
{
    public void Compress(string fileName) => Console.WriteLine($"Compressing GIF: {fileName}");
}
