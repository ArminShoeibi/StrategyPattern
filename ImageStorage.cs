using StrategyPattern.ImageCompressor;
using StrategyPattern.ImageFilter;

namespace StrategyPattern;
public class ImageStorage
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
