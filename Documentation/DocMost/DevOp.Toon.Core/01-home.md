# DevOp.Toon.Core

`DevOp.Toon.Core` is the lightweight contracts package for TOON-based .NET applications.

It is designed for shared model and contract libraries that need TOON annotations or configuration enums without pulling in the full serializer, service, or ASP.NET Core formatter stack.

## What this package contains

- `ToonPropertyNameAttribute`
- `ToonDelimiter`
- `ToonKeyFolding`
- `ToonPathExpansion`
- `ToonObjectArrayLayout`

## When to use it

Use `DevOp.Toon.Core` when a project only needs TOON-aware contracts, for example:

- shared DTO libraries
- cross-service contract packages
- model assemblies that should stay serializer-agnostic

## When not to use it

If you need encoding, decoding, dependency injection, or ASP.NET Core MVC formatter support, use:

- `DevOp.Toon`
- `DevOp.Toon.API`

## Recommended reading order

1. `Why Core Exists`
2. `Installation and Package Selection`
3. `ToonPropertyName Attribute`
4. `Shared Enums Reference`
