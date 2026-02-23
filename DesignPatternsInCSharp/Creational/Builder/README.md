# Builder Pattern

## 1) Intent
Construct complex objects step-by-step with readable configuration.

## 2) Problem it solves
Constructors become unreadable due to many optional parameters.

## 3) Core idea
Use builder methods for each option and finalize with `Build()`.

## 4) Participants in this example
ReportBuilder, Report

## 5) Step-by-step flow
- Define target object model.
- Provide fluent builder methods for options.
- Validate and build final object.
- Keep client code expressive and clear.

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
