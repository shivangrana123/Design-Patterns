# Adapter Pattern

## Intent
Convert one interface to another expected by clients.

## When to use
- You must integrate legacy/third-party APIs with incompatible interfaces.
- You want to keep client code unchanged while swapping providers.
- You need a translation layer for request/response models.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Wrapping external payment SDKs.
- Legacy logging API migration.
- Bridging old/new service contracts.
