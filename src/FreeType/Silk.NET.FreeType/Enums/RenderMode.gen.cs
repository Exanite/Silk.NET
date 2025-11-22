// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Render_Mode_")]
    public enum RenderMode : int
    {
        [NativeName("Name", "FT_RENDER_MODE_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "FT_RENDER_MODE_LIGHT")]
        Light = 0x1,
        [NativeName("Name", "FT_RENDER_MODE_MONO")]
        Mono = 0x2,
        [NativeName("Name", "FT_RENDER_MODE_LCD")]
        Lcd = 0x3,
        [NativeName("Name", "FT_RENDER_MODE_LCD_V")]
        LcdV = 0x4,
        [NativeName("Name", "FT_RENDER_MODE_SDF")]
        Sdf = 0x5,
        [NativeName("Name", "FT_RENDER_MODE_MAX")]
        Max = 0x6,
    }
}
