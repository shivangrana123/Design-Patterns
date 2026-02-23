# 🎯 Design Patterns in C#

A complete, documentation-first learning repository for common **C# design patterns**.

## What you get
- 24 pattern folders with concise documentation.
- A minimal `Example.cs` for each pattern.
- Catalog index to quickly navigate all patterns.

## Repository Structure

```text
DesignPatternsInCSharp/
├── Behavioral/
├── Creational/
├── Structural/
├── docs/
│   └── PATTERNS.md
└── tests/
    └── PatternSmokeTests.md
```

## Pattern Coverage

### Behavioral
Strategy, Command, Null Object, Specification, State, Data Access, Mediator, Chain of Responsibility, Template Method, Visitor, Memento, Rules Engine.

### Creational
Singleton, Builder, Prototype, Factory Method, Abstract Factory.

### Structural
Facade, Decorator, Composite, Adapter, Flyweight, Proxy, Bridge.

## Quick Start
1. Open `DesignPatternsInCSharp/docs/PATTERNS.md` and pick a pattern.
2. Read that folder's `README.md` for intent, usage guidance, and real-world examples.
3. Inspect `Example.cs` for the runnable implementation.
4. Run all pattern samples together:

```bash
dotnet run --project DesignPatternsInCSharp/src/DesignPatternsInCSharp.csproj
```

## Contributing
- Improve examples with richer domain scenarios.
- Add unit test projects per pattern/category.
- Expand “When to use” sections with trade-offs.

## License
MIT
