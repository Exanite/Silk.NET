// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CopyImageToMemoryInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkHostImageCopyFlags")]
    [SupportedApiProfile("vulkan")]
    public HostImageCopyFlags Flags;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan")]
    public ImageHandle SrcImage;

    [SupportedApiProfile("vulkan")]
    public ImageLayout SrcImageLayout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint RegionCount;

    [NativeTypeName("const VkImageToMemoryCopy *")]
    [SupportedApiProfile("vulkan")]
    public ImageToMemoryCopy* PRegions;
}
