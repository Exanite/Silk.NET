// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum BuildAccelerationStructureFlagsKHR : uint
{
    None = 0x0,
    AllowUpdateBit = 0x1,
    AllowCompactionBit = 0x2,
    PreferFastTraceBit = 0x4,
    PreferFastBuildBit = 0x8,
    LowMemoryBit = 0x10,
    MotionBitNV = 0x20,
    AllowOpacityMicromapUpdateBitEXT = 0x40,
    AllowDisableOpacityMicromapsBitEXT = 0x80,
    AllowOpacityMicromapDataUpdateBitEXT = 0x100,
    AllowDataAccessBit = 0x800,
    AllowClusterOpacityMicromapsBitNV = 0x1000,
    AllowUpdateBitNV = AllowUpdateBit,
    AllowCompactionBitNV = AllowCompactionBit,
    PreferFastTraceBitNV = PreferFastTraceBit,
    PreferFastBuildBitNV = PreferFastBuildBit,
    LowMemoryBitNV = LowMemoryBit,
}
