// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-paint_L613_C9")]
    [NativeName("Name", "hb_paint_composite_mode_t")]
    public enum PaintCompositeModeT : int
    {
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_CLEAR")]
        Clear = 0x0,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_SRC")]
        Src = 0x1,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_DEST")]
        Dest = 0x2,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_SRC_OVER")]
        SrcOver = 0x3,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_DEST_OVER")]
        DestOver = 0x4,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_SRC_IN")]
        SrcIn = 0x5,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_DEST_IN")]
        DestIn = 0x6,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_SRC_OUT")]
        SrcOut = 0x7,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_DEST_OUT")]
        DestOut = 0x8,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_SRC_ATOP")]
        SrcAtop = 0x9,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_DEST_ATOP")]
        DestAtop = 0xA,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_XOR")]
        Xor = 0xB,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_PLUS")]
        Plus = 0xC,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_SCREEN")]
        Screen = 0xD,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_OVERLAY")]
        Overlay = 0xE,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_DARKEN")]
        Darken = 0xF,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_LIGHTEN")]
        Lighten = 0x10,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_COLOR_DODGE")]
        ColorDodge = 0x11,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_COLOR_BURN")]
        ColorBurn = 0x12,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_HARD_LIGHT")]
        HardLight = 0x13,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_SOFT_LIGHT")]
        SoftLight = 0x14,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_DIFFERENCE")]
        Difference = 0x15,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_EXCLUSION")]
        Exclusion = 0x16,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_MULTIPLY")]
        Multiply = 0x17,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_HSL_HUE")]
        HslHue = 0x18,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_HSL_SATURATION")]
        HslSaturation = 0x19,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_HSL_COLOR")]
        HslColor = 0x1A,
        [NativeName("Name", "HB_PAINT_COMPOSITE_MODE_HSL_LUMINOSITY")]
        HslLuminosity = 0x1B,
    }
}
