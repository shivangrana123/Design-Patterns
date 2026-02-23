# Proxy Pattern

## Intent
Control access to an object via a surrogate.

## When to use
- You need lazy initialization, caching, security, or remote access concerns.
- Client should interact through same interface as real service.
- You want to wrap expensive dependencies transparently.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Virtual proxy for heavy images/documents.
- API client with access token checks.
- Caching proxy for read-heavy queries.
