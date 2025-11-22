// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-style_L62_C9")]
    [NativeName("Name", "hb_style_tag_t")]
    public enum StyleTagT : int
    {
        [NativeName("Name", "HB_STYLE_TAG_ITALIC")]
        StyleTagItalic = 0x6974616C,
        [NativeName("Name", "HB_STYLE_TAG_OPTICAL_SIZE")]
        StyleTagOpticalSize = 0x6F70737A,
        [NativeName("Name", "HB_STYLE_TAG_SLANT_ANGLE")]
        StyleTagSlantAngle = 0x736C6E74,
        [NativeName("Name", "HB_STYLE_TAG_SLANT_RATIO")]
        StyleTagSlantRatio = 0x536C6E74,
        [NativeName("Name", "HB_STYLE_TAG_WIDTH")]
        StyleTagWidth = 0x77647468,
        [NativeName("Name", "HB_STYLE_TAG_WEIGHT")]
        StyleTagWeight = 0x77676874,
        [NativeName("Name", "_HB_STYLE_TAG_MAX_VALUE")]
        StyleTagMaxValue = 0x7FFFFFFF,
    }
}
