// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Pixel_Mode_")]
    public enum PixelMode : int
    {
        [NativeName("Name", "FT_PIXEL_MODE_NONE")]
        None = 0x0,
        [NativeName("Name", "FT_PIXEL_MODE_MONO")]
        Mono = 0x1,
        [NativeName("Name", "FT_PIXEL_MODE_GRAY")]
        Gray = 0x2,
        [NativeName("Name", "FT_PIXEL_MODE_GRAY2")]
        Gray2 = 0x3,
        [NativeName("Name", "FT_PIXEL_MODE_GRAY4")]
        Gray4 = 0x4,
        [NativeName("Name", "FT_PIXEL_MODE_LCD")]
        Lcd = 0x5,
        [NativeName("Name", "FT_PIXEL_MODE_LCD_V")]
        LcdV = 0x6,
        [NativeName("Name", "FT_PIXEL_MODE_BGRA")]
        Bgra = 0x7,
        [NativeName("Name", "FT_PIXEL_MODE_MAX")]
        Max = 0x8,
    }
}
