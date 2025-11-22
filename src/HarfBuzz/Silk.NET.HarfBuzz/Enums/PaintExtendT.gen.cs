// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-paint_L358_C9")]
    [NativeName("Name", "hb_paint_extend_t")]
    public enum PaintExtendT : int
    {
        [NativeName("Name", "HB_PAINT_EXTEND_PAD")]
        Pad = 0x0,
        [NativeName("Name", "HB_PAINT_EXTEND_REPEAT")]
        Repeat = 0x1,
        [NativeName("Name", "HB_PAINT_EXTEND_REFLECT")]
        Reflect = 0x2,
    }
}
