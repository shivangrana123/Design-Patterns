# AbstractFactory Pattern

## 1) Intent
Create families of related objects without specifying concrete classes.

## 2) Problem it solves
A system needs multiple matching product sets (e.g., theme/provider).

## 3) Core idea
Use an abstract factory that returns related product variants.

## 4) Participants in this example
IUiFactory, IButton, IModal, LightThemeFactory, DarkThemeFactory

## 5) Step-by-step flow
- Create abstract product interfaces.
- Create concrete products for each family.
- Define abstract factory with methods per product.
- Swap complete families by changing factory only.

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
