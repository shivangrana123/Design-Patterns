# Prototype Pattern

## 1) Intent
Create new objects by cloning existing prototypes.

## 2) Problem it solves
Object creation is expensive or initialization is repetitive.

## 3) Core idea
Keep a configured prototype and clone it for variations.

## 4) Participants in this example
DocumentPrototype

## 5) Step-by-step flow
- Create base prototype instance.
- Implement clone behavior (deep/shallow as needed).
- Clone and tweak only required fields.
- Avoid repeating expensive setup logic.

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
