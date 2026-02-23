namespace DesignPatternsInCSharp.Structural.Bridge;

public interface IMessageSender
{
    string Send(string message);
}

public sealed class EmailSender : IMessageSender
{
    public string Send(string message)
    {
        return $"Email: {message}";
    }
}

public sealed class SmsSender : IMessageSender
{
    public string Send(string message)
    {
        return $"SMS: {message}";
    }
}

public abstract class Message
{
    protected Message(IMessageSender sender)
    {
        Sender = sender;
    }

    protected IMessageSender Sender { get; }

    public abstract string SendMessage(string body);
}

public sealed class AlertMessage : Message
{
    public AlertMessage(IMessageSender sender) : base(sender)
    {
    }

    public override string SendMessage(string body)
    {
        return Sender.Send($"ALERT - {body}");
    }
}

public static class Example
{
    public static string Run()
    {
        Message message = new AlertMessage(new SmsSender());
        return message.SendMessage("Server CPU is high");
    }
}
