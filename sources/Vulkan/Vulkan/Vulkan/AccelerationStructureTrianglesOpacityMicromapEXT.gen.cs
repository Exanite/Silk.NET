// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct AccelerationStructureTrianglesOpacityMicromapEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public IndexType IndexType;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressConstKHR IndexBuffer;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong IndexStride;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint BaseTriangle;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint UsageCountsCount;

    [NativeTypeName("const VkMicromapUsageEXT *")]
    [SupportedApiProfile("vulkan")]
    public MicromapUsageEXT* PUsageCounts;

    [NativeTypeName("const VkMicromapUsageEXT *const *")]
    [SupportedApiProfile("vulkan")]
    public MicromapUsageEXT** PpUsageCounts;

    [NativeTypeName("VkMicromapEXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    public MicromapEXTHandle Micromap;
}
