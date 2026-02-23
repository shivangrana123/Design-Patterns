# Prototype Pattern

## Intent
Clone existing instances efficiently.

## When to use
- Creating objects from scratch is expensive.
- You need many similar objects with small variations.
- You want to hide concrete class construction from clients.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Copying document templates.
- Spawning game entities from base stats.
- Cloning workflow definitions.
