// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct BufferCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkBufferCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public BufferCreateFlags Flags;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong Size;

    [NativeTypeName("VkBufferUsageFlags")]
    [SupportedApiProfile("vulkan")]
    public BufferUsageFlags Usage;

    [SupportedApiProfile("vulkan")]
    public SharingMode SharingMode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueFamilyIndexCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PQueueFamilyIndices;
}
