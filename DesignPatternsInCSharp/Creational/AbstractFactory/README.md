# AbstractFactory Pattern

## Intent
Create related object families without concrete coupling.

## When to use
- Multiple related products must be created together consistently.
- You need to switch whole families (e.g., themes/providers).
- Client code should remain independent of concrete implementations.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Cross-platform UI widget families.
- Database providers with matching commands/connections.
- Cloud provider specific SDK wrappers.
