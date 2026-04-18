# Getting Started

This page is the shortest path to using `DevOp.Toon.Core` in a shared model library.

## 1. Install the package

```bash
dotnet add package DevOp.Toon.Core
```

## 2. Annotate DTO members

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

## 3. Reference shared enums in configuration

```csharp
using DevOp.Toon.Core;

var delimiter = ToonDelimiter.COMMA;
var keyFolding = ToonKeyFolding.Safe;
var layout = ToonObjectArrayLayout.Columnar;
```

## 4. Keep the runtime out of your contracts layer

This package exists so contracts can stay lightweight. Add `DevOp.Toon` only in projects that actually serialize or deserialize data.

## Recommended next pages

- `Why Core Exists`
- `Shared Enums Reference`
