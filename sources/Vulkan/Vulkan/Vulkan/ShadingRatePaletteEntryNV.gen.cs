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
public enum ShadingRatePaletteEntryNV : uint
{
    [SupportedApiProfile("vulkan")]
    EntryNoInvocationsNV = 0,

    [SupportedApiProfile("vulkan")]
    Entry16InvocationsPerPixelNV = 1,

    [SupportedApiProfile("vulkan")]
    Entry8InvocationsPerPixelNV = 2,

    [SupportedApiProfile("vulkan")]
    Entry4InvocationsPerPixelNV = 3,

    [SupportedApiProfile("vulkan")]
    Entry2InvocationsPerPixelNV = 4,

    [SupportedApiProfile("vulkan")]
    Entry1InvocationPerPixelNV = 5,

    [SupportedApiProfile("vulkan")]
    Entry1InvocationPer2X1PixelsNV = 6,

    [SupportedApiProfile("vulkan")]
    Entry1InvocationPer1X2PixelsNV = 7,

    [SupportedApiProfile("vulkan")]
    Entry1InvocationPer2X2PixelsNV = 8,

    [SupportedApiProfile("vulkan")]
    Entry1InvocationPer4X2PixelsNV = 9,

    [SupportedApiProfile("vulkan")]
    Entry1InvocationPer2X4PixelsNV = 10,

    [SupportedApiProfile("vulkan")]
    Entry1InvocationPer4X4PixelsNV = 11,
}
