// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-common_L237_C9")]
    [NativeName("Name", "hb_direction_t")]
    public enum DirectionT : int
    {
        [NativeName("Name", "HB_DIRECTION_INVALID")]
        Invalid = 0x0,
        [NativeName("Name", "HB_DIRECTION_LTR")]
        Ltr = 0x4,
        [NativeName("Name", "HB_DIRECTION_RTL")]
        Rtl = 0x5,
        [NativeName("Name", "HB_DIRECTION_TTB")]
        Ttb = 0x6,
        [NativeName("Name", "HB_DIRECTION_BTT")]
        Btt = 0x7,
    }
}
