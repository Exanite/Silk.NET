// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangOptimizationLevel")]
    public enum SlangOptimizationLevel : uint
    {
        [NativeName("Name", "SLANG_OPTIMIZATION_LEVEL_NONE")]
        None = 0x0,
        [NativeName("Name", "SLANG_OPTIMIZATION_LEVEL_DEFAULT")]
        Default = 0x1,
        [NativeName("Name", "SLANG_OPTIMIZATION_LEVEL_HIGH")]
        High = 0x2,
        [NativeName("Name", "SLANG_OPTIMIZATION_LEVEL_MAXIMAL")]
        Maximal = 0x3,
    }
}
