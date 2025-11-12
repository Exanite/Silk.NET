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
public enum ComponentSwizzle : uint
{
    [SupportedApiProfile("vulkan")]
    Identity = 0,

    [SupportedApiProfile("vulkan")]
    Zero = 1,

    [SupportedApiProfile("vulkan")]
    One = 2,

    [SupportedApiProfile("vulkan")]
    R = 3,

    [SupportedApiProfile("vulkan")]
    G = 4,

    [SupportedApiProfile("vulkan")]
    B = 5,

    [SupportedApiProfile("vulkan")]
    A = 6,
}
