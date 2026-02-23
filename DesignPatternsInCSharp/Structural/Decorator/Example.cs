namespace DesignPatternsInCSharp.Structural.Decorator;

public interface IMessageSender
{
    string Send(string message);
}

public sealed class EmailSender : IMessageSender
{
    public string Send(string message)
    {
        return $"Email sent: {message}";
    }
}

public abstract class MessageSenderDecorator : IMessageSender
{
    protected MessageSenderDecorator(IMessageSender inner)
    {
        Inner = inner;
    }

    protected IMessageSender Inner { get; }

    public abstract string Send(string message);
}

public sealed class LoggingSenderDecorator : MessageSenderDecorator
{
    public LoggingSenderDecorator(IMessageSender inner) : base(inner)
    {
    }

    public override string Send(string message)
    {
        string result = Inner.Send(message);
        return $"[log] {result}";
    }
}

public static class Example
{
    public static string Run()
    {
        IMessageSender sender = new LoggingSenderDecorator(new EmailSender());
        return sender.Send("Welcome!");
    }
}
