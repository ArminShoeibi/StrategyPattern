namespace StrategyPattern.ImageFilter;
public class BlackAndWhiteFilter : IImageFilter
{
    public void Apply(string fileName) =>
        Console.WriteLine("Applying B&W Filter");
}