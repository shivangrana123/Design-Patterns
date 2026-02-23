using System.Collections.Generic;

namespace DesignPatternsInCSharp.Behavioral.Memento;

public sealed record EditorMemento(string Content);

public sealed class TextEditor
{
    public string Content { get; private set; } = string.Empty;

    public void Type(string text)
    {
        Content += text;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(Content);
    }

    public void Restore(EditorMemento memento)
    {
        Content = memento.Content;
    }
}

public sealed class History
{
    private readonly Stack<EditorMemento> _stack = new();

    public void Push(EditorMemento memento)
    {
        _stack.Push(memento);
    }

    public EditorMemento Pop()
    {
        return _stack.Pop();
    }
}

public static class Example
{
    public static string Run()
    {
        var editor = new TextEditor();
        var history = new History();

        history.Push(editor.Save());
        editor.Type("Design ");
        editor.Type("Patterns");

        editor.Restore(history.Pop());

        return editor.Content;
    }
}
