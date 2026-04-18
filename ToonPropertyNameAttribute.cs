#nullable enable
using System;

namespace DevOp.Toon.Core;

/// <summary>
/// Specifies the TOON property name to use when encoding and decoding a member.
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public sealed class ToonPropertyNameAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ToonPropertyNameAttribute"/> class.
    /// </summary>
    /// <param name="name">The TOON property name.</param>
    public ToonPropertyNameAttribute(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Gets the TOON property name.
    /// </summary>
    public string Name { get; }
}
