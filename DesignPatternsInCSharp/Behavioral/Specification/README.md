# Specification Pattern

## Intent
Compose business rules into reusable predicates.

## When to use
- Rules must be combined with AND/OR/NOT without duplicating code.
- You need to reuse the same rule in memory and repository queries.
- Business criteria evolve frequently and need testable units.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Product filtering in e-commerce search.
- Eligibility rules in lending/insurance.
- Compliance checks in onboarding workflows.
