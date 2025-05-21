// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "LayoutRules")]
    public enum LayoutRules : uint
    {
        [NativeName("Name", "Default")]
        Default = 0x0,
        [NativeName("Name", "MetalArgumentBufferTier2")]
        MetalArgumentBufferTier2 = 0x1,
    }
}
