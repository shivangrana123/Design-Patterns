# Singleton Pattern

## Intent
Guarantee one instance with global access point.

## When to use
- There must be exactly one shared instance (e.g., process-wide config).
- You need lazy or centralized access with controlled construction.
- You can tolerate global state trade-offs and test constraints.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Application configuration registry.
- In-process cache coordinator.
- Feature flag provider bootstrap.
