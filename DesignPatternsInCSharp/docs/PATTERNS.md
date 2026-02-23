# Pattern Catalog
This catalog links every implemented pattern and gives a one-line orientation for when to use it.

## Behavioral
- [Strategy](../Behavioral/Strategy/README.md): Choose among interchangeable algorithms at runtime.
- [Command](../Behavioral/Command/README.md): Wrap requests as objects for execution history and queueing.
- [NullObject](../Behavioral/NullObject/README.md): Replace null checks with a safe no-op implementation.
- [Specification](../Behavioral/Specification/README.md): Compose reusable business rules with clear intent.
- [State](../Behavioral/State/README.md): Change behavior when an object's state changes.
- [DataAccess](../Behavioral/DataAccess/README.md): Isolate persistence behind repository abstractions.
- [Mediator](../Behavioral/Mediator/README.md): Centralize communication between collaborating objects.
- [ChainOfResponsibility](../Behavioral/ChainOfResponsibility/README.md): Pass a request through a sequence of handlers.
- [TemplateMethod](../Behavioral/TemplateMethod/README.md): Keep a fixed algorithm skeleton and vary selected steps.
- [Visitor](../Behavioral/Visitor/README.md): Add operations without changing object structure classes.
- [Memento](../Behavioral/Memento/README.md): Capture and restore state safely.
- [RulesEngine](../Behavioral/RulesEngine/README.md): Externalize decision logic into independent rules.

## Creational
- [Singleton](../Creational/Singleton/README.md): Ensure one shared instance with a global access point.
- [Builder](../Creational/Builder/README.md): Build complex objects step-by-step.
- [Prototype](../Creational/Prototype/README.md): Clone configured objects efficiently.
- [FactoryMethod](../Creational/FactoryMethod/README.md): Delegate object creation to factories/subclasses.
- [AbstractFactory](../Creational/AbstractFactory/README.md): Create related object families consistently.

## Structural
- [Facade](../Structural/Facade/README.md): Offer a simplified API over a complex subsystem.
- [Decorator](../Structural/Decorator/README.md): Add behavior dynamically without subclass explosion.
- [Composite](../Structural/Composite/README.md): Treat individual and grouped objects uniformly.
- [Adapter](../Structural/Adapter/README.md): Bridge incompatible interfaces.
- [Flyweight](../Structural/Flyweight/README.md): Share intrinsic state to reduce memory usage.
- [Proxy](../Structural/Proxy/README.md): Control access via a surrogate object.
- [Bridge](../Structural/Bridge/README.md): Separate abstraction from implementation so both can vary.
