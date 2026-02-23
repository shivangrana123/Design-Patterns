# Decorator Pattern

## 1) Intent
Add behavior dynamically by wrapping objects.

## 2) Problem it solves
Subclassing for every feature combination causes class explosion.

## 3) Core idea
Create decorators that implement same interface and wrap components.

## 4) Participants in this example
IMessageSender, EmailSender, LoggingSenderDecorator, RetrySenderDecorator

## 5) Step-by-step flow
- Define core component interface.
- Implement base component.
- Create decorators with wrapped component reference.
- Compose decorators in desired runtime order.

## 6) Benefits
- Better separation of concerns and cleaner code boundaries.
- Easier testing because behavior is isolated into smaller units.
- Safer change management as features evolve.

## 7) Trade-offs
- More classes/interfaces than a quick inline implementation.
- Slightly higher upfront design effort.
- Requires team discipline to keep abstractions meaningful.

## 8) How to read the code
1. Start with `Example.Run()` to see the scenario entry point.
2. Inspect interfaces and concrete classes used by the pattern.
3. Follow object interactions in execution order.
4. Change one implementation and re-run to observe impact.

## 9) Example file
See `Example.cs` in this folder for a runnable, educational implementation.
