# 🎯 Design Patterns in C#

A documentation-first repository for learning and practicing **C# design patterns**.

## What you get
- 24 pattern folders with focused explanations.
- A runnable `Example.cs` implementation in each folder.
- A catalog to quickly navigate by category and pattern intent.

## Repository Structure

```text
DesignPatternsInCSharp/
├── Behavioral/
├── Creational/
├── Structural/
├── docs/
│   └── PATTERNS.md
├── src/
│   ├── DesignPatternsInCSharp.csproj
│   └── Program.cs
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
2. Read that folder's `README.md` using the numbered sections (Intent → Problem → Core Idea → Flow).
3. Inspect `Example.cs` and run the consolidated sample runner:

```bash
dotnet run --project DesignPatternsInCSharp/src/DesignPatternsInCSharp.csproj
```

## Contributing
- Keep examples educational and readable (multiline style preferred).
- Add scenario-specific tests when introducing behavior changes.
- Document trade-offs, not only benefits, in pattern READMEs.

## License
MIT
