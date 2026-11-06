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
    /// <summary>Use the selected protocol's standard object-array layout.</summary>
    /// <remarks>Official v4 supports uniform nested-object columns; legacy profiles tabularize primitive-only rows.</remarks>
    Auto,

    /// <summary>Use shared columns and complex-field spills according to the selected custom protocol.</summary>
    /// <remarks>The new custom profile supports nested groups and keyed-table spills. Official protocol encoders reject this layout.</remarks>
    Columnar
}

/// <summary>
/// Specifies the TOON protocol version.
/// </summary>
public enum ToonProtocolVersion
{
    /// <summary>Automatically detect protocol version during decoding.</summary>
    Auto = 0,

    /// <summary>Official TOON specification version 3.0.</summary>
    V3_0 = 300,

    /// <summary>Official TOON specification version 4.0.</summary>
    V4_0 = 400,

    /// <summary>Official TOON specification version 4.1.</summary>
    V4_1 = 401,

    /// <summary>Official TOON specification version 4.2.</summary>
    V4_2 = 402,

    /// <summary>Official TOON specification version 4.3.</summary>
    V4_3 = 403,

    /// <summary>Official TOON specification version 4.4.</summary>
    V4_4 = 404,

    /// <summary>DevOp custom legacy TOON protocol.</summary>
    CustomLegacy = 10000,

    /// <summary>DevOp custom TOON specification version 4.4.</summary>
    CustomV4_4 = 10404
}
