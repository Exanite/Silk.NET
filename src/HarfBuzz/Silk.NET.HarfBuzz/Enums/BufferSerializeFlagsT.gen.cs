// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_hb-buffer_L682_C9")]
    [NativeName("Name", "hb_buffer_serialize_flags_t")]
    public enum BufferSerializeFlagsT : int
    {
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_NO_CLUSTERS")]
        NoClusters = 0x1,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_NO_POSITIONS")]
        NoPositions = 0x2,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_NO_GLYPH_NAMES")]
        NoGlyphNames = 0x4,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_GLYPH_EXTENTS")]
        GlyphExtents = 0x8,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_GLYPH_FLAGS")]
        GlyphFlags = 0x10,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_NO_ADVANCES")]
        NoAdvances = 0x20,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FLAG_DEFINED")]
        Defined = 0x3F,
    }
}
