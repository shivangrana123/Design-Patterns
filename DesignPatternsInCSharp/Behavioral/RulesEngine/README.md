# RulesEngine Pattern

## 1) Intent
Represent decisions as composable rules evaluated at runtime.

## 2) Problem it solves
Decision logic is hardcoded and difficult to trace or update.

## 3) Core idea
Define small rules and evaluate them through a rule engine.

## 4) Participants in this example
IRule<T>, HighValueOrderRule, InternationalOrderRule, RuleEngine

## 5) Step-by-step flow
- Implement each rule independently.
- Engine evaluates rules against input context.
- Collect triggered rules and outcomes.
- Use results for approvals, flags, or actions.

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
