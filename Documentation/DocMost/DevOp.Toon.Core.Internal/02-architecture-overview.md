# Architecture Overview

`DevOp.Toon.Core` is the bottom of the TOON .NET package stack.

## Package role

It owns only the shared contracts:

- DTO annotation via `ToonPropertyNameAttribute`
- common enum values used by higher-level packages

It intentionally does not own:

- serialization logic
- decode logic
- DI registration
- ASP.NET Core integration

## Current source files

- `ToonPropertyNameAttribute.cs`
- `ToonEnums.cs`
- `DevOp.Toon.Core.csproj`

That is effectively the whole package surface.

## Dependency position

The package feeds:

- `DevOp.Toon`
- `DevOp.Toon.API`
- any shared DTO or contracts project that wants TOON-aware metadata

## Development rule of thumb

Changes here have low code volume but high compatibility impact. A small enum or attribute change can ripple into all higher-level packages.
