// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Kerning_Mode_")]
    public enum KerningMode : int
    {
        [NativeName("Name", "FT_KERNING_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "FT_KERNING_UNFITTED")]
        Unfitted = 0x1,
        [NativeName("Name", "FT_KERNING_UNSCALED")]
        Unscaled = 0x2,
    }
}
