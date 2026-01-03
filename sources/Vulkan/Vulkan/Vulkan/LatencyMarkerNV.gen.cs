// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum LatencyMarkerNV : uint
{
    SimulationStart = 0,
    SimulationEnd = 1,
    RendersubmitStart = 2,
    RendersubmitEnd = 3,
    PresentStart = 4,
    PresentEnd = 5,
    InputSample = 6,
    TriggerFlash = 7,
    OutOfBandRendersubmitStart = 8,
    OutOfBandRendersubmitEnd = 9,
    OutOfBandPresentStart = 10,
    OutOfBandPresentEnd = 11,
}
