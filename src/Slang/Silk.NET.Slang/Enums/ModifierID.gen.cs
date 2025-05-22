// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangModifierID")]
    public enum ModifierID : uint
    {
        [NativeName("Name", "SLANG_MODIFIER_SHARED")]
        Shared = 0x0,
        [NativeName("Name", "SLANG_MODIFIER_NO_DIFF")]
        NoDiff = 0x1,
        [NativeName("Name", "SLANG_MODIFIER_STATIC")]
        Static = 0x2,
        [NativeName("Name", "SLANG_MODIFIER_CONST")]
        Const = 0x3,
        [NativeName("Name", "SLANG_MODIFIER_EXPORT")]
        Export = 0x4,
        [NativeName("Name", "SLANG_MODIFIER_EXTERN")]
        Extern = 0x5,
        [NativeName("Name", "SLANG_MODIFIER_DIFFERENTIABLE")]
        Differentiable = 0x6,
        [NativeName("Name", "SLANG_MODIFIER_MUTATING")]
        Mutating = 0x7,
        [NativeName("Name", "SLANG_MODIFIER_IN")]
        In = 0x8,
        [NativeName("Name", "SLANG_MODIFIER_OUT")]
        Out = 0x9,
        [NativeName("Name", "SLANG_MODIFIER_INOUT")]
        Inout = 0xA,
    }
}
