# Composite Pattern

## 1) Intent
Treat single objects and groups uniformly in tree structures.

## 2) Problem it solves
Clients need separate logic for leaves and containers.

## 3) Core idea
Use common component interface for leaves and composites.

## 4) Participants in this example
IFileSystemNode, FileNode, FolderNode

## 5) Step-by-step flow
- Define common operation interface.
- Implement leaf behavior.
- Implement composite that stores children.
- Execute operations recursively.

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
