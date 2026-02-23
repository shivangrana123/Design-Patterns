# Pattern Catalog
This catalog links every implemented pattern example in this repository and explains when each is typically used.

## Behavioral
- [Strategy](../Behavioral/Strategy/README.md): Swap algorithms (pricing/validation) at runtime.
- [Command](../Behavioral/Command/README.md): Wrap requests as objects for queueing/undo.
- [NullObject](../Behavioral/NullObject/README.md): Replace `null` checks with no-op polymorphism.
- [Specification](../Behavioral/Specification/README.md): Compose reusable business rules.
- [State](../Behavioral/State/README.md): Change behavior by lifecycle state.
- [DataAccess](../Behavioral/DataAccess/README.md): Isolate persistence behind abstractions.
- [Mediator](../Behavioral/Mediator/README.md): Centralize communication between components.
- [ChainOfResponsibility](../Behavioral/ChainOfResponsibility/README.md): Pass requests through processing pipeline.
- [TemplateMethod](../Behavioral/TemplateMethod/README.md): Fix algorithm skeleton, vary individual steps.
- [Visitor](../Behavioral/Visitor/README.md): Add operations over object structures safely.
- [Memento](../Behavioral/Memento/README.md): Capture and restore previous state.
- [RulesEngine](../Behavioral/RulesEngine/README.md): Externalize decision logic as rules.

## Creational
- [Singleton](../Creational/Singleton/README.md): Ensure a single shared instance.
- [Builder](../Creational/Builder/README.md): Build complex objects step-by-step.
- [Prototype](../Creational/Prototype/README.md): Clone existing objects efficiently.
- [FactoryMethod](../Creational/FactoryMethod/README.md): Delegate construction to factories.
- [AbstractFactory](../Creational/AbstractFactory/README.md): Create related families of objects.

## Structural
- [Facade](../Structural/Facade/README.md): Provide a simpler API over complex systems.
- [Decorator](../Structural/Decorator/README.md): Layer optional behaviors dynamically.
- [Composite](../Structural/Composite/README.md): Treat groups and single objects uniformly.
- [Adapter](../Structural/Adapter/README.md): Translate between incompatible interfaces.
- [Flyweight](../Structural/Flyweight/README.md): Share intrinsic state to reduce memory.
- [Proxy](../Structural/Proxy/README.md): Control access via a stand-in object.
- [Bridge](../Structural/Bridge/README.md): Decouple abstraction and implementation axes.
