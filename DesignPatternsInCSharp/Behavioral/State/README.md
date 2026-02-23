# State Pattern

## Intent
Change behavior when internal state changes.

## When to use
- Object behavior depends heavily on lifecycle state.
- You want to avoid giant conditionals that check state repeatedly.
- Transitions between states must be explicit and controlled.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Order processing lifecycle.
- Document workflow (draft/review/published).
- Connection state in networking clients.
