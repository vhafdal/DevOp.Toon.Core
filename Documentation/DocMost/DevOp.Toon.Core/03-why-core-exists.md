# Why Core Exists

`DevOp.Toon.Core` exists to separate TOON contracts from TOON runtime behavior.

## The problem it solves

Shared model libraries often need:

- TOON-specific property naming
- shared enum values for configuration or options

But they should not need:

- encoders and decoders
- DI service registration
- MVC formatter dependencies

Pulling runtime packages into contracts assemblies makes dependency graphs heavier and couples shared models to concerns they do not own.

## The role of this package

`DevOp.Toon.Core` keeps the contracts layer small and stable by exposing only:

- the DTO naming attribute
- the shared enums used across the TOON stack

## How it fits into the stack

- `DevOp.Toon.Core`: contracts and shared enums
- `DevOp.Toon`: runtime serialization and DI
- `DevOp.Toon.API`: ASP.NET Core MVC transport integration

This split keeps contracts reusable while allowing higher layers to evolve independently.
