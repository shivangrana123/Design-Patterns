# ChainOfResponsibility Pattern

## 1) Intent
Pass a request through handlers until one handles it or chain ends.

## 2) Problem it solves
Single handler classes become bloated with many conditional branches.

## 3) Core idea
Split logic into handlers linked as a chain.

## 4) Participants in this example
IExpenseApprover, TeamLead, Manager, Director

## 5) Step-by-step flow
- Define a shared handler contract.
- Each handler decides handle-or-forward.
- Link handlers in desired order.
- Send request to first handler only.

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
