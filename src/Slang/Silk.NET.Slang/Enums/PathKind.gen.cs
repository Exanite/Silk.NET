// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "PathKind")]
    public enum PathKind : int
    {
        [NativeName("Name", "Simplified")]
        Simplified = 0x0,
        [NativeName("Name", "Canonical")]
        Canonical = 0x1,
        [NativeName("Name", "Display")]
        Display = 0x2,
        [NativeName("Name", "OperatingSystem")]
        OperatingSystem = 0x3,
        [NativeName("Name", "CountOf")]
        CountOf = 0x4,
    }
}
