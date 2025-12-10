// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum SwapchainCreateFlagsKHR : uint
{
    None = 0x0,
    SplitInstanceBindRegionsBit = 0x1,
    ProtectedBit = 0x2,
    MutableFormatBit = 0x4,
    PresentId2Bit = 0x40,
    PresentWait2Bit = 0x80,
    DeferredMemoryAllocationBit = 0x8,
    DeferredMemoryAllocationBitEXT = DeferredMemoryAllocationBit,
}
