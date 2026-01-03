// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeCapabilityFlagsKHR : uint
{
    None = 0x0,
    PrecedingExternallyEncodedBytesBit = 0x1,
    InsufficientBitstreamBufferRangeDetectionBit = 0x2,
    QuantizationDeltaMapBit = 0x4,
    EmphasisMapBit = 0x8,
}
