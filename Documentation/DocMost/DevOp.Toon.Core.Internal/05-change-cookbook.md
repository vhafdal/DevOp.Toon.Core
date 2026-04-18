# Change Cookbook

Use this page to find the first place to edit when working on `DevOp.Toon.Core`.

## Change or add a shared enum

Start with:

- `ToonEnums.cs`

Then validate:

- downstream build in `DevOp.Toon`
- downstream build in `DevOp.Toon.API`
- public docs and examples that mention enum values

## Change attribute behavior

Start with:

- `ToonPropertyNameAttribute.cs`

Then validate:

- attribute usage expectations in DTO projects
- downstream encode/decode behavior in `DevOp.Toon`

## Change package metadata or framework targets

Start with:

- `DevOp.Toon.Core.csproj`

Then validate:

- `dotnet build`
- `dotnet pack`
- package-facing docs if versioning or framework support messaging changed

## Update package positioning

Start with:

- `README.md`
- external DocMost pages

Keep the boundary clear: this package is for contracts and shared enums, not runtime serialization behavior.
