# DataAccess Pattern

## Intent
Abstract persistence concerns behind repositories/UoW.

## When to use
- Domain logic should not depend on SQL/ORM details.
- You want a seam for tests with in-memory fakes.
- Multiple persistence implementations may be swapped later.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Repository per aggregate root.
- Unit of Work transactions for multiple writes.
- CQRS query/read model separation.
