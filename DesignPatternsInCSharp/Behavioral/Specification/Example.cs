namespace DesignPatternsInCSharp.Behavioral.Specification;

public sealed record Customer(bool IsActive, decimal Spending);

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T candidate);
}

public sealed class ActiveCustomerSpecification : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer candidate)
    {
        return candidate.IsActive;
    }
}

public sealed class PremiumCustomerSpecification : ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer candidate)
    {
        return candidate.Spending >= 500m;
    }
}

public sealed class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _left;
    private readonly ISpecification<T> _right;

    public AndSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        _left = left;
        _right = right;
    }

    public bool IsSatisfiedBy(T candidate)
    {
        return _left.IsSatisfiedBy(candidate) && _right.IsSatisfiedBy(candidate);
    }
}

public static class Example
{
    public static string Run()
    {
        var customer = new Customer(IsActive: true, Spending: 800m);
        var rule = new AndSpecification<Customer>(
            new ActiveCustomerSpecification(),
            new PremiumCustomerSpecification());

        return rule.IsSatisfiedBy(customer)
            ? "Eligible for premium perks"
            : "Not eligible";
    }
}
