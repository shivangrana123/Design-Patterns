# Bridge Pattern

## Intent
Decouple abstraction from implementation so both can vary.

## When to use
- Both abstraction and implementation axes evolve independently.
- You want to avoid combinatorial subclass growth.
- Implementation should be swappable at runtime.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Notification types × delivery channels.
- Remote controls × device types.
- Document types × rendering backends.
