// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_hb-buffer_L802_C9")]
    [NativeName("Name", "hb_buffer_diff_flags_t")]
    public enum BufferDiffFlagsT : int
    {
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_EQUAL")]
        Equal = 0x0,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_CONTENT_TYPE_MISMATCH")]
        ContentTypeMismatch = 0x1,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_LENGTH_MISMATCH")]
        LengthMismatch = 0x2,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_NOTDEF_PRESENT")]
        NotdefPresent = 0x4,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_DOTTED_CIRCLE_PRESENT")]
        DottedCirclePresent = 0x8,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_CODEPOINT_MISMATCH")]
        CodepointMismatch = 0x10,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_CLUSTER_MISMATCH")]
        ClusterMismatch = 0x20,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_GLYPH_FLAGS_MISMATCH")]
        GlyphFlagsMismatch = 0x40,
        [NativeName("Name", "HB_BUFFER_DIFF_FLAG_POSITION_MISMATCH")]
        PositionMismatch = 0x80,
    }
}
