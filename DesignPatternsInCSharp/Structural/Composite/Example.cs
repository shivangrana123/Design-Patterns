using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsInCSharp.Structural.Composite;

public interface IFileSystemNode
{
    int GetSize();
}

public sealed class FileNode : IFileSystemNode
{
    public FileNode(int size)
    {
        Size = size;
    }

    public int Size { get; }

    public int GetSize()
    {
        return Size;
    }
}

public sealed class FolderNode : IFileSystemNode
{
    private readonly List<IFileSystemNode> _children = new();

    public void Add(IFileSystemNode child)
    {
        _children.Add(child);
    }

    public int GetSize()
    {
        return _children.Sum(child => child.GetSize());
    }
}

public static class Example
{
    public static string Run()
    {
        var root = new FolderNode();
        root.Add(new FileNode(100));
        root.Add(new FileNode(250));

        return root.GetSize().ToString();
    }
}
