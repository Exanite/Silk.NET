// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DependencyInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkDependencyFlags")]
    public DependencyFlags DependencyFlags;

    [NativeTypeName("uint32_t")]
    public uint MemoryBarrierCount;

    [NativeTypeName("const VkMemoryBarrier2 *")]
    public MemoryBarrier2* PMemoryBarriers;

    [NativeTypeName("uint32_t")]
    public uint BufferMemoryBarrierCount;

    [NativeTypeName("const VkBufferMemoryBarrier2 *")]
    public BufferMemoryBarrier2* PBufferMemoryBarriers;

    [NativeTypeName("uint32_t")]
    public uint ImageMemoryBarrierCount;

    [NativeTypeName("const VkImageMemoryBarrier2 *")]
    public ImageMemoryBarrier2* PImageMemoryBarriers;
}
