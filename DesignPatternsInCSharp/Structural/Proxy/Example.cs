namespace DesignPatternsInCSharp.Structural.Proxy;

public interface IImage
{
    string Display();
}

public sealed class RealImage : IImage
{
    private readonly string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
    }

    public string Display()
    {
        return $"Displaying {_fileName}";
    }
}

public sealed class ImageProxy : IImage
{
    private readonly string _fileName;
    private RealImage? _realImage;

    public ImageProxy(string fileName)
    {
        _fileName = fileName;
    }

    public string Display()
    {
        _realImage ??= new RealImage(_fileName);
        return _realImage.Display();
    }
}

public static class Example
{
    public static string Run()
    {
        IImage image = new ImageProxy("diagram.png");
        return image.Display();
    }
}
