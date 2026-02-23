# TemplateMethod Pattern

## 1) Intent
Define algorithm skeleton once while allowing selected steps to vary.

## 2) Problem it solves
Similar processes are copied with minor differences in steps.

## 3) Core idea
Place common flow in base class and override variable steps.

## 4) Participants in this example
ReportGenerator, SalesReportGenerator

## 5) Step-by-step flow
- Create base class with template method.
- Mark variable steps as abstract/virtual.
- Subclass and implement only changing steps.
- Execute template method to run fixed sequence.

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
