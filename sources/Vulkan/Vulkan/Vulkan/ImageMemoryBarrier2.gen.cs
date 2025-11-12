// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ImageMemoryBarrier2
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineStageFlags2")]
    [SupportedApiProfile("vulkan")]
    public PipelineStageFlags2 SrcStageMask;

    [NativeTypeName("VkAccessFlags2")]
    [SupportedApiProfile("vulkan")]
    public AccessFlags2 SrcAccessMask;

    [NativeTypeName("VkPipelineStageFlags2")]
    [SupportedApiProfile("vulkan")]
    public PipelineStageFlags2 DstStageMask;

    [NativeTypeName("VkAccessFlags2")]
    [SupportedApiProfile("vulkan")]
    public AccessFlags2 DstAccessMask;

    [SupportedApiProfile("vulkan")]
    public ImageLayout OldLayout;

    [SupportedApiProfile("vulkan")]
    public ImageLayout NewLayout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SrcQueueFamilyIndex;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DstQueueFamilyIndex;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan")]
    public ImageHandle Image;

    [SupportedApiProfile("vulkan")]
    public ImageSubresourceRange SubresourceRange;
}
