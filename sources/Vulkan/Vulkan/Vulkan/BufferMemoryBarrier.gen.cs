// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct BufferMemoryBarrier
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkAccessFlags")]
    [SupportedApiProfile("vulkan")]
    public AccessFlags SrcAccessMask;

    [NativeTypeName("VkAccessFlags")]
    [SupportedApiProfile("vulkan")]
    public AccessFlags DstAccessMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SrcQueueFamilyIndex;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DstQueueFamilyIndex;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan")]
    public BufferHandle Buffer;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong Offset;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong Size;
}
