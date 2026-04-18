# Public Surface and Compatibility

The public surface is tiny, so every change here should be treated as externally visible.

## Current public types

- `ToonPropertyNameAttribute`
- `ToonDelimiter`
- `ToonKeyFolding`
- `ToonPathExpansion`
- `ToonObjectArrayLayout`

## Compatibility guidance

Be careful with:

- renaming enum members
- changing enum semantics
- changing attribute constructor shape
- changing attribute usage targets or inheritance behavior

These changes can break:

- source compatibility in shared model projects
- runtime assumptions in `DevOp.Toon`
- formatter configuration paths in `DevOp.Toon.API`

## Safe versus risky changes

Lower-risk changes:

- package metadata updates
- documentation updates
- adding new target frameworks when compatibility is understood

Higher-risk changes:

- adding enum members that higher layers are not prepared to handle
- reinterpreting existing enum values
- modifying annotation behavior in ways the runtime does not expect

## Practical validation

After public-surface changes, validate downstream repos:

- build `DevOp.Toon`
- build `DevOp.Toon.API`
- check README and examples for drift
