# Strategy Pattern

## Intent
Select one of many interchangeable algorithms at runtime.

## When to use
- You have multiple pricing, sorting, or validation algorithms that can be swapped by configuration or user type.
- You want to remove long `if/else` or `switch` blocks that branch on behavior.
- You need to add new algorithms without changing the caller class.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Payment pricing and discount policies.
- Shipping rate calculators per region/carrier.
- Retry policies for API clients.
