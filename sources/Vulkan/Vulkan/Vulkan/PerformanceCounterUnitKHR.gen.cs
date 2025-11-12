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
public enum PerformanceCounterUnitKHR : uint
{
    [SupportedApiProfile("vulkan")]
    GenericKHR = 0,

    [SupportedApiProfile("vulkan")]
    PercentageKHR = 1,

    [SupportedApiProfile("vulkan")]
    NanosecondsKHR = 2,

    [SupportedApiProfile("vulkan")]
    BytesKHR = 3,

    [SupportedApiProfile("vulkan")]
    BytesPerSecondKHR = 4,

    [SupportedApiProfile("vulkan")]
    KelvinKHR = 5,

    [SupportedApiProfile("vulkan")]
    WattsKHR = 6,

    [SupportedApiProfile("vulkan")]
    VoltsKHR = 7,

    [SupportedApiProfile("vulkan")]
    AmpsKHR = 8,

    [SupportedApiProfile("vulkan")]
    HertzKHR = 9,

    [SupportedApiProfile("vulkan")]
    CyclesKHR = 10,
}
