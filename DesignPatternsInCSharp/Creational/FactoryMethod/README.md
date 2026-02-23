# FactoryMethod Pattern

## Intent
Delegate object creation to subclasses/factories.

## When to use
- Client code should depend on abstractions, not concrete constructors.
- Object creation varies by environment, channel, or tenant.
- You want to centralize creation and enforce invariants.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Notification channel factories.
- Storage provider factories.
- Serializer selection based on content type.
