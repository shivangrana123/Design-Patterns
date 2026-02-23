# Specification Pattern

## 1) Intent
Model business rules as composable, reusable specifications.

## 2) Problem it solves
Business filters are duplicated in many places and hard to combine.

## 3) Core idea
Wrap each rule in a specification and compose with AND/OR/NOT.

## 4) Participants in this example
ISpecification<T>, ActiveCustomerSpecification, PremiumCustomerSpecification

## 5) Step-by-step flow
- Implement small, focused specifications.
- Add combinators to join rules.
- Use composed rules in services/repositories.
- Test each rule independently.

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
