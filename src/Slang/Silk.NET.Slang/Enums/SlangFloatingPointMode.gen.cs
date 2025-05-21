// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangFloatingPointMode")]
    public enum SlangFloatingPointMode : uint
    {
        [NativeName("Name", "SLANG_FLOATING_POINT_MODE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "SLANG_FLOATING_POINT_MODE_FAST")]
        Fast = 0x1,
        [NativeName("Name", "SLANG_FLOATING_POINT_MODE_PRECISE")]
        Precise = 0x2,
    }
}
