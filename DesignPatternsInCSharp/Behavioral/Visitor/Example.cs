using System.Collections.Generic;

namespace DesignPatternsInCSharp.Behavioral.Visitor;

public interface IVisitor
{
    decimal VisitBook(Book book);
    decimal VisitVideo(Video video);
}

public interface IElement
{
    decimal Accept(IVisitor visitor);
}

public sealed class Book : IElement
{
    public Book(decimal price)
    {
        Price = price;
    }

    public decimal Price { get; }

    public decimal Accept(IVisitor visitor)
    {
        return visitor.VisitBook(this);
    }
}

public sealed class Video : IElement
{
    public Video(decimal price)
    {
        Price = price;
    }

    public decimal Price { get; }

    public decimal Accept(IVisitor visitor)
    {
        return visitor.VisitVideo(this);
    }
}

public sealed class DiscountVisitor : IVisitor
{
    public decimal VisitBook(Book book)
    {
        return book.Price * 0.9m;
    }

    public decimal VisitVideo(Video video)
    {
        return video.Price * 0.8m;
    }
}

public static class Example
{
    public static string Run()
    {
        var items = new List<IElement>
        {
            new Book(100m),
            new Video(50m)
        };

        var visitor = new DiscountVisitor();
        decimal total = 0m;

        foreach (var item in items)
        {
            total += item.Accept(visitor);
        }

        return total.ToString("0.00");
    }
}
