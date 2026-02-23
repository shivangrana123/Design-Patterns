# ChainOfResponsibility Pattern

## Intent
Pass a request through a chain of handlers.

## When to use
- A request may be handled by one of many processors.
- You need configurable processing pipelines.
- Handlers should be reusable and independently testable.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- HTTP middleware pipelines.
- Validation chains on commands.
- Support ticket escalation paths.
