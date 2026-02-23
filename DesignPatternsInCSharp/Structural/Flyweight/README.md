# Flyweight Pattern

## Intent
Share intrinsic state to support many fine-grained objects.

## When to use
- You have huge numbers of similar objects causing memory pressure.
- Large immutable state can be shared across instances.
- Extrinsic state can be supplied from context at runtime.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Text editor glyph caching.
- Map marker/icon reuse.
- Game particle type sharing.
