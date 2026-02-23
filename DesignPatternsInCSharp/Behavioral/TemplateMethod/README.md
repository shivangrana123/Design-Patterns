# TemplateMethod Pattern

## Intent
Define algorithm skeleton and override specific steps.

## When to use
- Process steps are stable but some steps vary by subtype.
- You want a common flow while preventing step reordering.
- You need to reuse invariant setup/cleanup logic.

## Example (C#)
See `Example.cs` in this folder for a runnable, minimal implementation.

## Real-world use cases
- File importers for CSV/JSON/XML.
- Batch processing job templates.
- Test fixture setup pipelines.
