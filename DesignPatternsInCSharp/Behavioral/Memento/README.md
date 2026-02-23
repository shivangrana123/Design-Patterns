# Memento Pattern

## 1) Intent
Capture and restore object state without exposing internals.

## 2) Problem it solves
Undo/rollback is needed but internal fields should stay encapsulated.

## 3) Core idea
Save snapshots as mementos managed by a caretaker.

## 4) Participants in this example
TextEditor, EditorMemento, History

## 5) Step-by-step flow
- Originator creates immutable memento snapshot.
- Caretaker stores snapshots over time.
- Restore previous memento when undo is requested.
- Keep originator internals hidden from caretaker.

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
