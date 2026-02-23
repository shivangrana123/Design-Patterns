# Bridge Pattern

## 1) Intent
Separate abstraction from implementation so both evolve independently.

## 2) Problem it solves
Two dimensions of variation lead to many subclass combinations.

## 3) Core idea
Split into abstraction hierarchy and implementation hierarchy.

## 4) Participants in this example
Message, IMessageSender, AlertMessage, EmailSender, SmsSender

## 5) Step-by-step flow
- Define implementation interface.
- Implement concrete implementors.
- Define abstraction containing implementor reference.
- Combine any abstraction with any implementor at runtime.

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
