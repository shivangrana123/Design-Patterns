namespace DesignPatternsInCSharp.Behavioral.NullObject;

public interface ICustomer
{
    string GetGreeting();
}

public sealed class RealCustomer : ICustomer
{
    private readonly string _name;

    public RealCustomer(string name)
    {
        _name = name;
    }

    public string GetGreeting()
    {
        return $"Welcome back, {_name}!";
    }
}

public sealed class NullCustomer : ICustomer
{
    public string GetGreeting()
    {
        return "Welcome, guest user.";
    }
}

public sealed class GreetingService
{
    public string BuildGreeting(ICustomer customer)
    {
        return customer.GetGreeting();
    }
}

public static class Example
{
    public static string Run()
    {
        var service = new GreetingService();
        ICustomer customer = new NullCustomer();

        return service.BuildGreeting(customer);
    }
}
