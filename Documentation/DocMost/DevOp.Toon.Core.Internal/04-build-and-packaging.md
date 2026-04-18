# Build and Packaging

`DevOp.Toon.Core` is straightforward to build, but packaging details matter because this repo is mostly package surface.

## Standard commands

```bash
dotnet restore
dotnet build DevOp.Toon.Core.slnx
dotnet pack DevOp.Toon.Core.csproj -c Release
```

## Important project-file behavior

Current project settings include:

- multi-targeting for `netstandard2.0`, `net8.0`, `net9.0`, `net10.0`
- `GeneratePackageOnBuild=true`
- signed assembly
- packed `README.md`
- documentation file generation

## Where packaging metadata lives

Check `DevOp.Toon.Core.csproj` for:

- version
- package description
- tags
- repository metadata
- target frameworks

## Practical guidance

Because there is no test project here, `build` and `pack` are the most important direct validations in this repo. For behavior validation, use downstream repos that consume these contracts.
