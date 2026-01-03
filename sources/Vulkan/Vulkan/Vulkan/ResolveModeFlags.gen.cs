// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ResolveModeFlags : uint
{
    None = 0x0,
    SampleZeroBit = 0x1,
    AverageBit = 0x2,
    MinBit = 0x4,
    MaxBit = 0x8,
    ExternalFormatDownsampleBitANDROID = 0x10,
    NoneKHR = None,
    SampleZeroBitKHR = SampleZeroBit,
    AverageBitKHR = AverageBit,
    MinBitKHR = MinBit,
    MaxBitKHR = MaxBit,
}
