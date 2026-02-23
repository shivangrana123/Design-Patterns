using System;
using System.Collections.Generic;

var demos = new List<(string Category, string Pattern, Func<string> Execute)>
{
    // Behavioral
    ("Behavioral", "Strategy", () => DesignPatternsInCSharp.Behavioral.Strategy.Example.Run().ToString("0.00")),
    ("Behavioral", "Command", () => DesignPatternsInCSharp.Behavioral.Command.Example.Run().ToString()),
    ("Behavioral", "NullObject", () => DesignPatternsInCSharp.Behavioral.NullObject.Example.Run()),
    ("Behavioral", "Specification", () => DesignPatternsInCSharp.Behavioral.Specification.Example.Run()),
    ("Behavioral", "State", () => DesignPatternsInCSharp.Behavioral.State.Example.Run()),
    ("Behavioral", "DataAccess", () => DesignPatternsInCSharp.Behavioral.DataAccess.Example.Run()),
    ("Behavioral", "Mediator", () => DesignPatternsInCSharp.Behavioral.Mediator.Example.Run()),
    ("Behavioral", "ChainOfResponsibility", () => DesignPatternsInCSharp.Behavioral.ChainOfResponsibility.Example.Run()),
    ("Behavioral", "TemplateMethod", () => DesignPatternsInCSharp.Behavioral.TemplateMethod.Example.Run()),
    ("Behavioral", "Visitor", () => DesignPatternsInCSharp.Behavioral.Visitor.Example.Run()),
    ("Behavioral", "Memento", () => DesignPatternsInCSharp.Behavioral.Memento.Example.Run()),
    ("Behavioral", "RulesEngine", () => DesignPatternsInCSharp.Behavioral.RulesEngine.Example.Run()),

    // Creational
    ("Creational", "Singleton", () => DesignPatternsInCSharp.Creational.Singleton.Example.Run()),
    ("Creational", "Builder", () => DesignPatternsInCSharp.Creational.Builder.Example.Run()),
    ("Creational", "Prototype", () => DesignPatternsInCSharp.Creational.Prototype.Example.Run()),
    ("Creational", "FactoryMethod", () => DesignPatternsInCSharp.Creational.FactoryMethod.Example.Run()),
    ("Creational", "AbstractFactory", () => DesignPatternsInCSharp.Creational.AbstractFactory.Example.Run()),

    // Structural
    ("Structural", "Facade", () => DesignPatternsInCSharp.Structural.Facade.Example.Run()),
    ("Structural", "Decorator", () => DesignPatternsInCSharp.Structural.Decorator.Example.Run()),
    ("Structural", "Composite", () => DesignPatternsInCSharp.Structural.Composite.Example.Run()),
    ("Structural", "Adapter", () => DesignPatternsInCSharp.Structural.Adapter.Example.Run()),
    ("Structural", "Flyweight", () => DesignPatternsInCSharp.Structural.Flyweight.Example.Run()),
    ("Structural", "Proxy", () => DesignPatternsInCSharp.Structural.Proxy.Example.Run()),
    ("Structural", "Bridge", () => DesignPatternsInCSharp.Structural.Bridge.Example.Run())
};

Console.WriteLine("Design Patterns Demo Runner");
Console.WriteLine(new string('-', 32));

string currentCategory = string.Empty;

foreach (var (category, pattern, execute) in demos)
{
    if (!string.Equals(currentCategory, category, StringComparison.Ordinal))
    {
        currentCategory = category;
        Console.WriteLine();
        Console.WriteLine($"[{currentCategory}]");
    }

    string output = execute();
    Console.WriteLine($"- {pattern}: {output}");
}
