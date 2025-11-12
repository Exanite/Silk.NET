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
public enum BlendFactor : uint
{
    [SupportedApiProfile("vulkan")]
    Zero = 0,

    [SupportedApiProfile("vulkan")]
    One = 1,

    [SupportedApiProfile("vulkan")]
    SrcColor = 2,

    [SupportedApiProfile("vulkan")]
    OneMinusSrcColor = 3,

    [SupportedApiProfile("vulkan")]
    DstColor = 4,

    [SupportedApiProfile("vulkan")]
    OneMinusDstColor = 5,

    [SupportedApiProfile("vulkan")]
    SrcAlpha = 6,

    [SupportedApiProfile("vulkan")]
    OneMinusSrcAlpha = 7,

    [SupportedApiProfile("vulkan")]
    DstAlpha = 8,

    [SupportedApiProfile("vulkan")]
    OneMinusDstAlpha = 9,

    [SupportedApiProfile("vulkan")]
    ConstantColor = 10,

    [SupportedApiProfile("vulkan")]
    OneMinusConstantColor = 11,

    [SupportedApiProfile("vulkan")]
    ConstantAlpha = 12,

    [SupportedApiProfile("vulkan")]
    OneMinusConstantAlpha = 13,

    [SupportedApiProfile("vulkan")]
    SrcAlphaSaturate = 14,

    [SupportedApiProfile("vulkan")]
    Src1Color = 15,

    [SupportedApiProfile("vulkan")]
    OneMinusSrc1Color = 16,

    [SupportedApiProfile("vulkan")]
    Src1Alpha = 17,

    [SupportedApiProfile("vulkan")]
    OneMinusSrc1Alpha = 18,
}
