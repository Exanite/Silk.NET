// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CopyMemoryToImageIndirectInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkAddressCopyFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public AddressCopyFlagsKHR SrcCopyFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CopyCount;

    [SupportedApiProfile("vulkan")]
    public StridedDeviceAddressRangeKHR CopyAddressRange;

    [NativeTypeName("VkImage")]
    [SupportedApiProfile("vulkan")]
    public ImageHandle DstImage;

    [SupportedApiProfile("vulkan")]
    public ImageLayout DstImageLayout;

    [NativeTypeName("const VkImageSubresourceLayers *")]
    [SupportedApiProfile("vulkan")]
    public ImageSubresourceLayers* PImageSubresources;
}
