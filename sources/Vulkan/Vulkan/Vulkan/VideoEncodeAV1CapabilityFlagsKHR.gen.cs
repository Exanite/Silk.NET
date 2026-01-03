// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeAV1CapabilityFlagsKHR : uint
{
    None = 0x0,
    PerRateControlGroupMinMaxQIndexBit = 0x1,
    GenerateObuExtensionHeaderBit = 0x2,
    PrimaryReferenceCdfOnlyBit = 0x4,
    FrameSizeOverrideBit = 0x8,
    MotionVectorScalingBit = 0x10,
    CompoundPredictionIntraRefreshBit = 0x20,
}
