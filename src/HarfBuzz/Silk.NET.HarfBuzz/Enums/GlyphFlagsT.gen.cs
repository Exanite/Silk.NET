// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_hb-buffer_L160_C9")]
    [NativeName("Name", "hb_glyph_flags_t")]
    public enum GlyphFlagsT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "HB_GLYPH_FLAG_UNSAFE_TO_BREAK")]
        UnsafeToBreak = 0x1,
        [NativeName("Name", "HB_GLYPH_FLAG_UNSAFE_TO_CONCAT")]
        UnsafeToConcat = 0x2,
        [NativeName("Name", "HB_GLYPH_FLAG_SAFE_TO_INSERT_TATWEEL")]
        SafeToInsertTatweel = 0x4,
        [NativeName("Name", "HB_GLYPH_FLAG_DEFINED")]
        Defined = 0x7,
    }
}
