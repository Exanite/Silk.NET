// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct BlitImageInfo2
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkImage")]
    public ImageHandle SrcImage;
    public ImageLayout SrcImageLayout;

    [NativeTypeName("VkImage")]
    public ImageHandle DstImage;
    public ImageLayout DstImageLayout;

    [NativeTypeName("uint32_t")]
    public uint RegionCount;

    [NativeTypeName("const VkImageBlit2 *")]
    public ImageBlit2* PRegions;
    public Filter Filter;
}
