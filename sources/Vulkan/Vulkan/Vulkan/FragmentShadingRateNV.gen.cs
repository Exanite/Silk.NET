// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum FragmentShadingRateNV : uint
{
    [SupportedApiProfile("vulkan")]
    Rate1InvocationPerPixelNV = 0,

    [SupportedApiProfile("vulkan")]
    Rate1InvocationPer1X2PixelsNV = 1,

    [SupportedApiProfile("vulkan")]
    Rate1InvocationPer2X1PixelsNV = 4,

    [SupportedApiProfile("vulkan")]
    Rate1InvocationPer2X2PixelsNV = 5,

    [SupportedApiProfile("vulkan")]
    Rate1InvocationPer2X4PixelsNV = 6,

    [SupportedApiProfile("vulkan")]
    Rate1InvocationPer4X2PixelsNV = 9,

    [SupportedApiProfile("vulkan")]
    Rate1InvocationPer4X4PixelsNV = 10,

    [SupportedApiProfile("vulkan")]
    Rate2InvocationsPerPixelNV = 11,

    [SupportedApiProfile("vulkan")]
    Rate4InvocationsPerPixelNV = 12,

    [SupportedApiProfile("vulkan")]
    Rate8InvocationsPerPixelNV = 13,

    [SupportedApiProfile("vulkan")]
    Rate16InvocationsPerPixelNV = 14,

    [SupportedApiProfile("vulkan")]
    RateNoInvocationsNV = 15,
}
