# Adapter Pattern

## 1) Intent
Convert one interface into another expected by client code.

## 2) Problem it solves
Legacy or external API does not match the application contract.

## 3) Core idea
Adapter translates calls and data between interfaces.

## 4) Participants in this example
IPaymentGateway, LegacyPaymentService, LegacyPaymentAdapter

## 5) Step-by-step flow
- Define target interface clients use.
- Keep existing/legacy service unchanged.
- Implement adapter wrapping legacy service.
- Translate calls and return expected format.

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
