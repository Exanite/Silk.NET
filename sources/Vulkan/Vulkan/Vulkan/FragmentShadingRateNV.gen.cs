// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum FragmentShadingRateNV : uint
{
    Rate1InvocationPerPixel = 0,
    Rate1InvocationPer1X2Pixels = 1,
    Rate1InvocationPer2X1Pixels = 4,
    Rate1InvocationPer2X2Pixels = 5,
    Rate1InvocationPer2X4Pixels = 6,
    Rate1InvocationPer4X2Pixels = 9,
    Rate1InvocationPer4X4Pixels = 10,
    Rate2InvocationsPerPixel = 11,
    Rate4InvocationsPerPixel = 12,
    Rate8InvocationsPerPixel = 13,
    Rate16InvocationsPerPixel = 14,
    RateNoInvocations = 15,
}
