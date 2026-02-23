# Decorator Pattern

## Intent
Attach responsibilities to objects dynamically.

## When to use
- You need optional features layered at runtime.
- Subclass explosion would occur for all feature combinations.
- You want to follow open/closed principle for behavior extension.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Middleware-style request processing.
- Adding caching/retry/logging around services.
- UI component enhancement (borders, scrollbars).
