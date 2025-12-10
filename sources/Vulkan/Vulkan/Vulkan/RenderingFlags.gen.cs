// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum RenderingFlags : uint
{
    None = 0x0,
    ContentsSecondaryCommandBuffersBit = 0x1,
    SuspendingBit = 0x2,
    ResumingBit = 0x4,
    EnableLegacyDitheringBitEXT = 0x8,
    ContentsInlineBitKHR = 0x10,
    PerLayerFragmentDensityBitVALVE = 0x20,
    LocalReadConcurrentAccessControlBitKHR = 0x100,
    ContentsSecondaryCommandBuffersBitKHR = ContentsSecondaryCommandBuffersBit,
    SuspendingBitKHR = SuspendingBit,
    ResumingBitKHR = ResumingBit,
    ContentsInlineBitEXT = ContentsInlineBitKHR,
}
