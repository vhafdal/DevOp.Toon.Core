#nullable enable
using System;

namespace DevOp.Toon.Core;

/// <summary>
/// Marks a property that captures object keys with no matching member when decoding, and writes
/// its entries as sibling keys after the declared members when encoding.
/// </summary>
/// <remarks>
/// The property type must be <c>IDictionary&lt;string, object?&gt;</c> or
/// <c>Dictionary&lt;string, object?&gt;</c>, and a type may declare at most one such property,
/// inherited properties included. When an entry's key equals a member's TOON name or CLR name,
/// the member wins and the entry is skipped. Runtime support depends on the protocol version;
/// see the DevOp.Toon documentation.
/// </remarks>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public sealed class ToonExtensionDataAttribute : Attribute
{
}
