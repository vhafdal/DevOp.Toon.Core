# Shared Enums Reference

`DevOp.Toon.Core` provides the shared enum types used across the TOON stack.

## `ToonDelimiter`

Controls the delimiter used for tabular rows and inline primitive arrays.

Values:

- `COMMA`
- `TAB`
- `PIPE`

## `ToonKeyFolding`

Controls key folding behavior.

Values:

- `Off`
- `Safe`

`Safe` allows nested single-key wrappers to collapse into dotted paths.

## `ToonPathExpansion`

Controls whether dotted keys are expanded back into nested structures during decode.

Values:

- `Off`
- `Safe`

## `ToonObjectArrayLayout`

Controls how arrays of objects are encoded.

Values:

- `Auto`
- `Columnar`

`Columnar` is the more compact mode used by the runtime when shared primitive columns can be emitted in a tabular header while complex values spill below each row.

## Why these enums live here

These enums are shared across configuration, contracts, runtime behavior, and formatter integration, so they belong in the contracts package rather than the serializer package.
