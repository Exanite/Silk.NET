// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct ImageMemoryBarrier
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkAccessFlags")]
    public AccessFlags SrcAccessMask;

    [NativeTypeName("VkAccessFlags")]
    public AccessFlags DstAccessMask;
    public ImageLayout OldLayout;
    public ImageLayout NewLayout;

    [NativeTypeName("uint32_t")]
    public uint SrcQueueFamilyIndex;

    [NativeTypeName("uint32_t")]
    public uint DstQueueFamilyIndex;

    [NativeTypeName("VkImage")]
    public ImageHandle Image;
    public ImageSubresourceRange SubresourceRange;
}
