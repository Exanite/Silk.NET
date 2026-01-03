// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct CopyMemoryToImageIndirectInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkAddressCopyFlagsKHR")]
    public AddressCopyFlagsKHR SrcCopyFlags;

    [NativeTypeName("uint32_t")]
    public uint CopyCount;
    public StridedDeviceAddressRangeKHR CopyAddressRange;

    [NativeTypeName("VkImage")]
    public ImageHandle DstImage;
    public ImageLayout DstImageLayout;

    [NativeTypeName("const VkImageSubresourceLayers *")]
    public ImageSubresourceLayers* PImageSubresources;
}
