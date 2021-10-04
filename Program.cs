using StrategyPattern;
using StrategyPattern.ImageCompressor;
using StrategyPattern.ImageFilter;

ImageStorage imageStorage = new(new PNGCompressor(), new BlackAndWhiteFilter());
imageStorage.Store("me.png");
