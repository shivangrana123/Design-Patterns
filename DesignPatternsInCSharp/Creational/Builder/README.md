# Builder Pattern

## Intent
Build complex objects step-by-step.

## When to use
- Objects require many optional parameters or construction steps.
- You want readable construction with validation before `Build()`.
- Construction logic should be separated from representation.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Creating HTTP requests with optional headers/body.
- Building complex domain aggregates.
- Generating reports with configurable sections.
