// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangLayoutRules")]
    public enum SlangLayoutRules : uint
    {
        [NativeName("Name", "SLANG_LAYOUT_RULES_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "SLANG_LAYOUT_RULES_METAL_ARGUMENT_BUFFER_TIER_2")]
        MetalArgumentBufferTier2 = 0x1,
        [NativeName("Name", "SLANG_LAYOUT_RULES_DEFAULT_STRUCTURED_BUFFER")]
        DefaultStructuredBuffer = 0x2,
        [NativeName("Name", "SLANG_LAYOUT_RULES_DEFAULT_CONSTANT_BUFFER")]
        DefaultConstantBuffer = 0x3,
    }
}
