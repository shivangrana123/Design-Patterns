# NullObject Pattern

## Intent
Use a neutral object to avoid repeated null checks.

## When to use
- A dependency can be optional but call sites should remain simple.
- You want deterministic default behavior instead of `null` handling everywhere.
- You want to apply polymorphism even when no-op behavior is needed.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Guest user profile in authentication flows.
- No-op logger in tests or local runs.
- Fallback notification sender.
