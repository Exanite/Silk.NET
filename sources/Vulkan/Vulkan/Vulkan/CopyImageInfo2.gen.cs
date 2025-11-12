// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CopyImageInfo2
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan")]
    public ImageHandle SrcImage;

    [SupportedApiProfile("vulkan")]
    public ImageLayout SrcImageLayout;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan")]
    public ImageHandle DstImage;

    [SupportedApiProfile("vulkan")]
    public ImageLayout DstImageLayout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint RegionCount;

    [NativeTypeName("const VkImageCopy2 *")]
    [SupportedApiProfile("vulkan")]
    public ImageCopy2* PRegions;
}
