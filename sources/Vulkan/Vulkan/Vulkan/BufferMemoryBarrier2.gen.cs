// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct BufferMemoryBarrier2
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineStageFlags2")]
    public PipelineStageFlags2 SrcStageMask;

    [NativeTypeName("VkAccessFlags2")]
    public AccessFlags2 SrcAccessMask;

    [NativeTypeName("VkPipelineStageFlags2")]
    public PipelineStageFlags2 DstStageMask;

    [NativeTypeName("VkAccessFlags2")]
    public AccessFlags2 DstAccessMask;

    [NativeTypeName("uint32_t")]
    public uint SrcQueueFamilyIndex;

    [NativeTypeName("uint32_t")]
    public uint DstQueueFamilyIndex;

    [NativeTypeName("VkBuffer")]
    public BufferHandle Buffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong Offset;

    [NativeTypeName("VkDeviceSize")]
    public ulong Size;
}
