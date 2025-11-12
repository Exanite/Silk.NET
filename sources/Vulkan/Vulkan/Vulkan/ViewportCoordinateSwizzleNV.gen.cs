// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum ViewportCoordinateSwizzleNV : uint
{
    [SupportedApiProfile("vulkan")]
    PositiveXNV = 0,

    [SupportedApiProfile("vulkan")]
    NegativeXNV = 1,

    [SupportedApiProfile("vulkan")]
    PositiveYNV = 2,

    [SupportedApiProfile("vulkan")]
    NegativeYNV = 3,

    [SupportedApiProfile("vulkan")]
    PositiveZNV = 4,

    [SupportedApiProfile("vulkan")]
    NegativeZNV = 5,

    [SupportedApiProfile("vulkan")]
    PositiveWNV = 6,

    [SupportedApiProfile("vulkan")]
    NegativeWNV = 7,
}
