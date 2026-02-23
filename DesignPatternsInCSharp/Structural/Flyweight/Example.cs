using System.Collections.Generic;

namespace DesignPatternsInCSharp.Structural.Flyweight;

public sealed class TreeType
{
    public TreeType(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public string Name { get; }
    public string Color { get; }
}

public sealed class TreeFactory
{
    private readonly Dictionary<string, TreeType> _cache = new();

    public TreeType GetTreeType(string name, string color)
    {
        string key = $"{name}:{color}";

        if (!_cache.ContainsKey(key))
        {
            _cache[key] = new TreeType(name, color);
        }

        return _cache[key];
    }
}

public static class Example
{
    public static string Run()
    {
        var factory = new TreeFactory();
        TreeType oakA = factory.GetTreeType("Oak", "Green");
        TreeType oakB = factory.GetTreeType("Oak", "Green");

        return ReferenceEquals(oakA, oakB) ? "Shared flyweight" : "Different instances";
    }
}
