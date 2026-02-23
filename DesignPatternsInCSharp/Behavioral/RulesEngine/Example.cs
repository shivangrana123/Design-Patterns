using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsInCSharp.Behavioral.RulesEngine;

public sealed record Order(decimal Total, bool IsInternational);

public interface IRule<in T>
{
    string Name { get; }
    bool IsMatch(T input);
}

public sealed class HighValueOrderRule : IRule<Order>
{
    public string Name => "HighValueOrder";

    public bool IsMatch(Order input)
    {
        return input.Total >= 1_000m;
    }
}

public sealed class InternationalOrderRule : IRule<Order>
{
    public string Name => "InternationalOrder";

    public bool IsMatch(Order input)
    {
        return input.IsInternational;
    }
}

public sealed class RuleEngine<T>
{
    private readonly IReadOnlyList<IRule<T>> _rules;

    public RuleEngine(IReadOnlyList<IRule<T>> rules)
    {
        _rules = rules;
    }

    public IReadOnlyList<string> Evaluate(T input)
    {
        return _rules
            .Where(rule => rule.IsMatch(input))
            .Select(rule => rule.Name)
            .ToList();
    }
}

public static class Example
{
    public static string Run()
    {
        var order = new Order(1_200m, true);
        var engine = new RuleEngine<Order>(new IRule<Order>[]
        {
            new HighValueOrderRule(),
            new InternationalOrderRule()
        });

        var matchedRules = engine.Evaluate(order);
        return string.Join(", ", matchedRules);
    }
}
