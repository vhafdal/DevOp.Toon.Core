# Installation and Package Selection

Use this page when deciding whether a project should reference `DevOp.Toon.Core` or a higher-level TOON package.

## Install the package

```bash
dotnet add package DevOp.Toon.Core
```

## Choose the right package

### Use `DevOp.Toon.Core`

Use this package when a project only needs:

- `ToonPropertyNameAttribute`
- shared TOON enums

This is the right choice for:

- DTO projects
- contracts libraries
- projects that should stay serialization-light

### Use `DevOp.Toon`

Use `DevOp.Toon` when a project needs:

- encoding
- decoding
- JSON interop
- `ToonService` or `IToonService`

### Use `DevOp.Toon.API`

Use `DevOp.Toon.API` when TOON should participate in ASP.NET Core MVC request and response formatting.

## Practical architecture

In a multi-project solution, keep `DevOp.Toon.Core` in shared contracts and move TOON runtime or transport dependencies outward to application and API layers.
