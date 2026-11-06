using System;

namespace DevOp.Toon.Core;

/// <summary>Maps supported protocol versions to stable transport names.</summary>
public static class ToonProtocolVersions
{
    /// <summary>Formats a concrete version for HTTP metadata.</summary>
    public static string Format(ToonProtocolVersion version) => version switch
    {
        ToonProtocolVersion.V3_0 => "3.0",
        ToonProtocolVersion.V4_0 => "4.0",
        ToonProtocolVersion.V4_1 => "4.1",
        ToonProtocolVersion.V4_2 => "4.2",
        ToonProtocolVersion.V4_3 => "4.3",
        ToonProtocolVersion.V4_4 => "4.4",
        ToonProtocolVersion.CustomLegacy => "custom-legacy",
        ToonProtocolVersion.CustomV4_4 => "custom-4.4",
        _ => throw new ArgumentOutOfRangeException(nameof(version))
    };

    /// <summary>Parses a concrete transport version or its enum name.</summary>
    public static bool TryParse(string? value, out ToonProtocolVersion version)
    {
        version = value?.Trim().ToLowerInvariant() switch
        {
            "3.0" => ToonProtocolVersion.V3_0,
            "4.0" => ToonProtocolVersion.V4_0,
            "4.1" => ToonProtocolVersion.V4_1,
            "4.2" => ToonProtocolVersion.V4_2,
            "4.3" => ToonProtocolVersion.V4_3,
            "4.4" => ToonProtocolVersion.V4_4,
            "custom-legacy" => ToonProtocolVersion.CustomLegacy,
            "custom-4.4" => ToonProtocolVersion.CustomV4_4,
            _ => ToonProtocolVersion.Auto
        };
        return version != ToonProtocolVersion.Auto || (Enum.TryParse(value, true, out version) && version != ToonProtocolVersion.Auto && Enum.IsDefined(typeof(ToonProtocolVersion), version));
    }
}
