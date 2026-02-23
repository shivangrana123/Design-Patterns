# RulesEngine Pattern

## Intent
Externalize decision logic as composable rules.

## When to use
- Business decisions change often and should be configured.
- You need traceable rule evaluation outcomes.
- Multiple rule sets must be applied to different tenants/contexts.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- Promotion eligibility engines.
- Fraud detection pre-checks.
- Policy-based access decisions.
