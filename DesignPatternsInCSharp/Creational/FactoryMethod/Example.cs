namespace DesignPatternsInCSharp.Creational.FactoryMethod;

public interface INotification { string Send(string message); }
public sealed class EmailNotification : INotification { public string Send(string message)=>$"Email: {message}"; }
public abstract class NotificationFactory { public abstract INotification Create(); }
public sealed class EmailFactory : NotificationFactory { public override INotification Create()=>new EmailNotification(); }

public static class Example
{
    public static string Run()=> new EmailFactory().Create().Send("Hello");
}
