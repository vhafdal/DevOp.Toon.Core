# ToonPropertyName Attribute

`ToonPropertyNameAttribute` lets a model member declare the TOON property name that should be used during encode and decode operations.

## Example

```csharp
using DevOp.Toon.Core;

public sealed class ProductDto
{
    [ToonPropertyName("product_id")]
    public int Id { get; init; }

    [ToonPropertyName("display_name")]
    public string Name { get; init; } = string.Empty;
}
```

## Why it matters

This attribute is useful when:

- TOON property names must differ from CLR member names
- shared contracts need stable wire names
- DTO packages should express transport intent without depending on the runtime package

## Important behavior

- applies to properties
- not repeatable on the same member
- inherited by derived types

## Relationship to the runtime

The attribute lives in `DevOp.Toon.Core`, but it becomes meaningful when consumed by higher-level packages such as `DevOp.Toon`.
