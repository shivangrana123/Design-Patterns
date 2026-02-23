# Proxy Pattern

## 1) Intent
Control access to a real object through a surrogate.

## 2) Problem it solves
You need lazy loading, caching, access checks, or remote delegation.

## 3) Core idea
Proxy implements same interface and forwards conditionally.

## 4) Participants in this example
IImage, RealImage, ImageProxy

## 5) Step-by-step flow
- Create interface shared by real subject and proxy.
- Implement real subject behavior.
- Implement proxy with control logic.
- Client uses proxy transparently.

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
