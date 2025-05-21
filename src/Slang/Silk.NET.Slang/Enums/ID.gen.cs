// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "ID")]
    public enum ID : uint
    {
        [NativeName("Name", "Shared")]
        Shared = 0x0,
        [NativeName("Name", "NoDiff")]
        NoDiff = 0x1,
        [NativeName("Name", "Static")]
        Static = 0x2,
        [NativeName("Name", "Const")]
        Const = 0x3,
        [NativeName("Name", "Export")]
        Export = 0x4,
        [NativeName("Name", "Extern")]
        Extern = 0x5,
        [NativeName("Name", "Differentiable")]
        Differentiable = 0x6,
        [NativeName("Name", "Mutating")]
        Mutating = 0x7,
        [NativeName("Name", "In")]
        In = 0x8,
        [NativeName("Name", "Out")]
        Out = 0x9,
        [NativeName("Name", "InOut")]
        InOut = 0xA,
    }
}
