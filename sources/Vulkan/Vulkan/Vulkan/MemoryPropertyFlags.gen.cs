// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum MemoryPropertyFlags : uint
{
    None = 0x0,
    DeviceLocalBit = 0x1,
    HostVisibleBit = 0x2,
    HostCoherentBit = 0x4,
    HostCachedBit = 0x8,
    LazilyAllocatedBit = 0x10,
    ProtectedBit = 0x20,
    DeviceCoherentBitAMD = 0x40,
    DeviceUncachedBitAMD = 0x80,
    RdmaCapableBitNV = 0x100,
}
