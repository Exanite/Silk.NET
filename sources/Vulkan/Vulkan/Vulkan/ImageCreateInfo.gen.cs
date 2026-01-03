// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct ImageCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkImageCreateFlags")]
    public ImageCreateFlags Flags;
    public ImageType ImageType;
    public Format Format;
    public Extent3D Extent;

    [NativeTypeName("uint32_t")]
    public uint MipLevels;

    [NativeTypeName("uint32_t")]
    public uint ArrayLayers;
    public SampleCountFlags Samples;
    public ImageTiling Tiling;

    [NativeTypeName("VkImageUsageFlags")]
    public ImageUsageFlags Usage;
    public SharingMode SharingMode;

    [NativeTypeName("uint32_t")]
    public uint QueueFamilyIndexCount;

    [NativeTypeName("const uint32_t *")]
    public uint* PQueueFamilyIndices;
    public ImageLayout InitialLayout;
}
