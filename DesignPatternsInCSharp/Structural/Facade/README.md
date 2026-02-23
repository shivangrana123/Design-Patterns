# Facade Pattern

## Intent
Provide a simplified API over a complex subsystem.

## When to use
- A subsystem is complex and clients need a simpler entry point.
- You want to reduce coupling to many low-level types.
- You need a stable API while subsystem internals evolve.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Checkout orchestration over payment/inventory/shipping.
- Media pipeline wrapper services.
- Third-party SDK simplification layer.
