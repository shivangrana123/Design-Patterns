# Strategy Pattern

## 1) Intent
Select one of many interchangeable algorithms at runtime.

## 2) Problem it solves
The caller becomes tightly coupled to `if/else` blocks that choose behavior.

## 3) Core idea
Move each algorithm into its own strategy class behind a shared interface.

## 4) Participants in this example
CheckoutService, IDiscountStrategy, RegularDiscount, PremiumDiscount

## 5) Step-by-step flow
- Create a strategy interface for the varying behavior.
- Implement each algorithm in a separate concrete strategy.
- Inject the selected strategy into the context object.
- Call the context without changing caller logic when strategies change.

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
