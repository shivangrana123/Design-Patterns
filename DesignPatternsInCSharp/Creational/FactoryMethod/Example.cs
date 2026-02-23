namespace DesignPatternsInCSharp.Creational.FactoryMethod;

public interface INotification
{
    string Send(string message);
}

public sealed class EmailNotification : INotification
{
    public string Send(string message)
    {
        return $"Email: {message}";
    }
}

public abstract class NotificationFactory
{
    public abstract INotification Create();
}

public sealed class EmailFactory : NotificationFactory
{
    public override INotification Create()
    {
        return new EmailNotification();
    }
}

public static class Example
{
    public static string Run()
    {
        NotificationFactory factory = new EmailFactory();
        INotification notification = factory.Create();

        return notification.Send("Hello");
    }
}
