# Visitor Pattern

## Intent
Add new operations over object structures without changing classes.

## When to use
- Object structure is stable but operations change frequently.
- You need type-safe double dispatch across element variants.
- You want to keep operations separate from data structures.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- AST analysis and code generation.
- Report/export generation over domain graphs.
- Pricing engines over product hierarchies.
