namespace DesignPatternsInCSharp.Behavioral.Strategy;

public interface IDiscountStrategy
{
    decimal Apply(decimal amount);
}

public sealed class RegularDiscount : IDiscountStrategy
{
    public decimal Apply(decimal amount)
    {
        return amount;
    }
}

public sealed class PremiumDiscount : IDiscountStrategy
{
    public decimal Apply(decimal amount)
    {
        return amount * 0.9m;
    }
}

public sealed class CheckoutService
{
    private readonly IDiscountStrategy _strategy;

    public CheckoutService(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal Total(decimal subtotal)
    {
        return _strategy.Apply(subtotal);
    }
}

public static class Example
{
    public static decimal Run()
    {
        var service = new CheckoutService(new PremiumDiscount());
        return service.Total(100m);
    }
}
