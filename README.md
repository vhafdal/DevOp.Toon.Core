# DevOp.Toon.Core

`DevOp.Toon.Core` is the lightweight contracts package for TOON-based .NET applications.

Use this package when a shared models assembly only needs:

- `ToonPropertyNameAttribute` for DTO field naming
- shared TOON enums such as `ToonDelimiter`, `ToonKeyFolding`, `ToonPathExpansion`, and `ToonObjectArrayLayout`

If you need encoding, decoding, DI integration, or ASP.NET Core formatters, use `DevOp.Toon` instead.

## Installation

```bash
dotnet add package DevOp.Toon.Core
```

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

You can also reference the shared enums from application or configuration code:

```csharp
using DevOp.Toon.Core;

var delimiter = ToonDelimiter.COMMA;
var keyFolding = ToonKeyFolding.Safe;
var layout = ToonObjectArrayLayout.Columnar;
```

## Target Frameworks

This package targets:

- `netstandard2.0`
- `net8.0`
- `net9.0`
- `net10.0`

## Package Role

Keep `DevOp.Toon.Core` in contracts and model projects to avoid pulling the full formatter and serializer stack into shared libraries.
