// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum PerformanceCounterUnitKHR : uint
{
    Generic = 0,
    Percentage = 1,
    Nanoseconds = 2,
    Bytes = 3,
    BytesPerSecond = 4,
    Kelvin = 5,
    Watts = 6,
    Volts = 7,
    Amps = 8,
    Hertz = 9,
    Cycles = 10,
}
