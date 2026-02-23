# State Pattern

## 1) Intent
Allow an object to alter behavior when its internal state changes.

## 2) Problem it solves
Large conditionals based on state become difficult to maintain.

## 3) Core idea
Move state-specific behavior into separate state classes.

## 4) Participants in this example
OrderContext, IOrderState, DraftState, PaidState, ShippedState

## 5) Step-by-step flow
- Define a state interface with shared operations.
- Create one class per state.
- Context delegates behavior to active state.
- State object controls transitions to next valid state.

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
