# NullObject Pattern

## 1) Intent
Avoid repeated null checks by providing a neutral implementation.

## 2) Problem it solves
Call sites are noisy and error-prone because `null` checks are everywhere.

## 3) Core idea
Return a no-op implementation that follows the same interface contract.

## 4) Participants in this example
ICustomer, RealCustomer, NullCustomer, GreetingService

## 5) Step-by-step flow
- Define the common interface.
- Create a real implementation for normal behavior.
- Create a null object with safe default behavior.
- Use the interface everywhere without special-case null logic.

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
