# DevOp.Toon.Core

`DevOp.Toon.Core` is the lightweight contracts package for TOON-based .NET applications.

**Version scope:** this guide covers Core 0.2.0.

Use this package when a shared models assembly only needs:

- `ToonPropertyNameAttribute` for DTO field naming
- shared TOON enums such as `ToonDelimiter`, `ToonKeyFolding`, `ToonPathExpansion`, and `ToonObjectArrayLayout`
- `ToonProtocolVersion` and `ToonProtocolVersions` for explicit version selection and transport names

Use `DevOp.Toon` for encoding, decoding, and DI integration; add `DevOp.Toon.API` for ASP.NET Core MVC formatters.

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
var layout = ToonObjectArrayLayout.Columnar; // Custom formats only.
var version = ToonProtocolVersion.CustomV4_4;
string wireName = ToonProtocolVersions.Format(version); // custom-4.4
bool supported = ToonProtocolVersions.TryParse("4.4", out var officialVersion);
```

## Protocol versions

`ToonProtocolVersion` includes `Auto`, `V3_0`, `V4_0` through `V4_4`, `CustomLegacy`, and `CustomV4_4`. `Auto` is a decode policy only. Encoding and HTTP metadata require a concrete version.

`ToonProtocolVersions.Format` emits `3.0`, `4.0` through `4.4`, `custom-legacy`, or `custom-4.4`; it rejects `Auto` and undefined enum values. `TryParse` accepts these transport names and concrete enum names, and rejects `Auto` and unsupported values. These contracts do not themselves encode or decode payloads.

Runtime 0.3.0 defaults encoding to official 4.4. `CustomLegacy` selects the earlier custom format; `CustomV4_4` selects the new custom format with nested header groups and row/keyed spills. Custom formats require compatible runtime support at both ends.

## Target Frameworks

This package targets:

- `netstandard2.0`
- `net8.0`
- `net9.0`
- `net10.0`

## Package Role

Keep `DevOp.Toon.Core` in contracts and model projects to avoid pulling the full formatter and serializer stack into shared libraries.
