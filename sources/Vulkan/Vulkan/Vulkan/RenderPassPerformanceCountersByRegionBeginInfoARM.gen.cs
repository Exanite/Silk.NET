// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct RenderPassPerformanceCountersByRegionBeginInfoARM
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint CounterAddressCount;

    [NativeTypeName("const VkDeviceAddress *")]
    public ulong* PCounterAddresses;

    [NativeTypeName("VkBool32")]
    public uint SerializeRegions;

    [NativeTypeName("uint32_t")]
    public uint CounterIndexCount;

    [NativeTypeName("uint32_t *")]
    public uint* PCounterIndices;
}
