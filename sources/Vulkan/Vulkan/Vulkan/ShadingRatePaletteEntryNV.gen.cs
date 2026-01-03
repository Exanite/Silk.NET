// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum ShadingRatePaletteEntryNV : uint
{
    EntryNoInvocations = 0,
    Entry16InvocationsPerPixel = 1,
    Entry8InvocationsPerPixel = 2,
    Entry4InvocationsPerPixel = 3,
    Entry2InvocationsPerPixel = 4,
    Entry1InvocationPerPixel = 5,
    Entry1InvocationPer2X1Pixels = 6,
    Entry1InvocationPer1X2Pixels = 7,
    Entry1InvocationPer2X2Pixels = 8,
    Entry1InvocationPer4X2Pixels = 9,
    Entry1InvocationPer2X4Pixels = 10,
    Entry1InvocationPer4X4Pixels = 11,
}
