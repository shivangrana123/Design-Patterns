# Visitor Pattern

## 1) Intent
Add new operations to object structures without modifying element classes.

## 2) Problem it solves
Adding behavior requires editing many element classes repeatedly.

## 3) Core idea
Separate operations into visitor classes and dispatch with `Accept`.

## 4) Participants in this example
IVisitor, IElement, Book, Video, PriceVisitor

## 5) Step-by-step flow
- Element exposes `Accept(visitor)`.
- Visitor has visit method per element type.
- Structure iterates and calls `Accept`.
- Add new operations by adding new visitors only.

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
