# Flyweight Pattern

## 1) Intent
Share immutable intrinsic state to reduce memory usage.

## 2) Problem it solves
Large number of similar objects consume too much memory.

## 3) Core idea
Store shared state in flyweights and pass varying state externally.

## 4) Participants in this example
TreeType, TreeFactory, Tree

## 5) Step-by-step flow
- Identify intrinsic vs extrinsic state.
- Create flyweight factory/cache.
- Reuse existing flyweights for repeated intrinsic data.
- Provide extrinsic data at usage time.

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
