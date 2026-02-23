# Command Pattern

## Intent
Encapsulate a request as an object for queueing, logging, and undo.

## When to use
- You need to decouple UI actions from business execution logic.
- You want to queue, schedule, or replay operations later.
- You need undo/redo support by storing inverse commands.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Toolbar/menu actions in desktop apps.
- Job queues for background processing.
- Audit trails of user actions.
