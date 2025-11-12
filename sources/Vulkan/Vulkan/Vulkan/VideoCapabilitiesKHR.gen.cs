// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoCapabilitiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoCapabilityFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoCapabilityFlagsKHR Flags;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MinBitstreamBufferOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MinBitstreamBufferSizeAlignment;

    [SupportedApiProfile("vulkan")]
    public Extent2D PictureAccessGranularity;

    [SupportedApiProfile("vulkan")]
    public Extent2D MinCodedExtent;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxCodedExtent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDpbSlots;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxActiveReferencePictures;

    [SupportedApiProfile("vulkan")]
    public ExtensionProperties StdHeaderVersion;
}
