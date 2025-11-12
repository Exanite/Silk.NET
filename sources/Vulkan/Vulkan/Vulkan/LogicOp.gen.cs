// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum LogicOp : uint
{
    [SupportedApiProfile("vulkan")]
    Clear = 0,

    [SupportedApiProfile("vulkan")]
    And = 1,

    [SupportedApiProfile("vulkan")]
    AndReverse = 2,

    [SupportedApiProfile("vulkan")]
    Copy = 3,

    [SupportedApiProfile("vulkan")]
    AndInverted = 4,

    [SupportedApiProfile("vulkan")]
    NoOp = 5,

    [SupportedApiProfile("vulkan")]
    Xor = 6,

    [SupportedApiProfile("vulkan")]
    Or = 7,

    [SupportedApiProfile("vulkan")]
    Nor = 8,

    [SupportedApiProfile("vulkan")]
    Equivalent = 9,

    [SupportedApiProfile("vulkan")]
    Invert = 10,

    [SupportedApiProfile("vulkan")]
    OrReverse = 11,

    [SupportedApiProfile("vulkan")]
    CopyInverted = 12,

    [SupportedApiProfile("vulkan")]
    OrInverted = 13,

    [SupportedApiProfile("vulkan")]
    Nand = 14,

    [SupportedApiProfile("vulkan")]
    Set = 15,
}
