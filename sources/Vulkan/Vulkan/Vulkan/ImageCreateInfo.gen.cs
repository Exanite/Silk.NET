// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ImageCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkImageCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public ImageCreateFlags Flags;

    [SupportedApiProfile("vulkan")]
    public ImageType ImageType;

    [SupportedApiProfile("vulkan")]
    public Format Format;

    [SupportedApiProfile("vulkan")]
    public Extent3D Extent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MipLevels;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ArrayLayers;

    [SupportedApiProfile("vulkan")]
    public SampleCountFlags Samples;

    [SupportedApiProfile("vulkan")]
    public ImageTiling Tiling;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan")]
    public ImageUsageFlags Usage;

    [SupportedApiProfile("vulkan")]
    public SharingMode SharingMode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueFamilyIndexCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PQueueFamilyIndices;

    [SupportedApiProfile("vulkan")]
    public ImageLayout InitialLayout;
}
