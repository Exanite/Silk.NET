// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Glyph_Format_")]
    public enum GlyphFormat : int
    {
        [NativeName("Name", "FT_GLYPH_FORMAT_NONE")]
        None = 0x0,
        [NativeName("Name", "FT_GLYPH_FORMAT_COMPOSITE")]
        Composite = 0x636F6D70,
        [NativeName("Name", "FT_GLYPH_FORMAT_BITMAP")]
        Bitmap = 0x62697473,
        [NativeName("Name", "FT_GLYPH_FORMAT_OUTLINE")]
        Outline = 0x6F75746C,
        [NativeName("Name", "FT_GLYPH_FORMAT_PLOTTER")]
        Plotter = 0x706C6F74,
        [NativeName("Name", "FT_GLYPH_FORMAT_SVG")]
        Svg = 0x53564720,
    }
}
