namespace DevOp.Toon.Core;

/// <summary>
/// Controls the delimiter used for tabular array rows and inline primitive arrays.
/// </summary>
public enum ToonDelimiter
{
    /// <summary>Comma ,</summary>
    COMMA,

    /// <summary>Tab \t</summary>
    TAB,

    /// <summary>Pipe |</summary>
    PIPE
}

/// <summary>
/// Key folding options.
/// </summary>
public enum ToonKeyFolding
{
    /// <summary>Key folding disabled.</summary>
    Off,

    /// <summary>Nested objects with single keys are collapsed into dotted paths.</summary>
    Safe
}

/// <summary>
/// Path expansion options.
/// </summary>
public enum ToonPathExpansion
{
    /// <summary>Path expansion disabled.</summary>
    Off,

    /// <summary>Keys containing dots are expanded into nested structures.</summary>
    Safe
}

/// <summary>
/// Controls how arrays of objects are encoded.
/// </summary>
public enum ToonObjectArrayLayout
{
    /// <summary>Use classic behavior and only tabularize fully primitive rows.</summary>
    Auto,

    /// <summary>Use shared primitive columns as a tabular header and spill complex fields below each row.</summary>
    Columnar
}
