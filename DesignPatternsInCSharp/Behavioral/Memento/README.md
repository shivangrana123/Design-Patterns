# Memento Pattern

## Intent
Capture and restore object state safely.

## When to use
- You need undo/checkpoint behavior without exposing internals.
- State snapshots should be stored and restored later.
- You want immutable history records.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Text editor undo stacks.
- Game save checkpoints.
- Configuration rollback in admin tools.
