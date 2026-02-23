# Command Pattern

## Intent
Encapsulate a request as an object for queueing, logging, and undo.

## When to use
- You need clear separation of concerns.
- You want easier unit testing through abstractions.
- You expect this behavior to evolve independently.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Enterprise application modules.
- API orchestration and workflows.
- Domain services with evolving requirements.
