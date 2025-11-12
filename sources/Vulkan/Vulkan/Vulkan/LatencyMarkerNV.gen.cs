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
public enum LatencyMarkerNV : uint
{
    [SupportedApiProfile("vulkan")]
    SimulationStartNV = 0,

    [SupportedApiProfile("vulkan")]
    SimulationEndNV = 1,

    [SupportedApiProfile("vulkan")]
    RendersubmitStartNV = 2,

    [SupportedApiProfile("vulkan")]
    RendersubmitEndNV = 3,

    [SupportedApiProfile("vulkan")]
    PresentStartNV = 4,

    [SupportedApiProfile("vulkan")]
    PresentEndNV = 5,

    [SupportedApiProfile("vulkan")]
    InputSampleNV = 6,

    [SupportedApiProfile("vulkan")]
    TriggerFlashNV = 7,

    [SupportedApiProfile("vulkan")]
    OutOfBandRendersubmitStartNV = 8,

    [SupportedApiProfile("vulkan")]
    OutOfBandRendersubmitEndNV = 9,

    [SupportedApiProfile("vulkan")]
    OutOfBandPresentStartNV = 10,

    [SupportedApiProfile("vulkan")]
    OutOfBandPresentEndNV = 11,
}
