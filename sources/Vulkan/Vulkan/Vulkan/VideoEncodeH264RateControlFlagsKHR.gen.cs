// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeH264RateControlFlagsKHR : uint
{
    None = 0x0,
    AttemptHrdComplianceBit = 0x1,
    RegularGopBit = 0x2,
    ReferencePatternFlatBit = 0x4,
    ReferencePatternDyadicBit = 0x8,
    TemporalLayerPatternDyadicBit = 0x10,
}
