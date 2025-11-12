// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum GeometryInstanceFlagsKHR : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    TriangleFacingCullDisableBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan")]
    TriangleFlipFacingBitKHR = 0x00000002,

    [SupportedApiProfile("vulkan")]
    ForceOpaqueBitKHR = 0x00000004,

    [SupportedApiProfile("vulkan")]
    ForceNoOpaqueBitKHR = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    ForceOpacityMicromap2StateBitEXT = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    DisableOpacityMicromapsBitEXT = 0x00000020,

    [SupportedApiProfile("vulkan")]
    TriangleFrontCounterclockwiseBitKHR = TriangleFlipFacingBitKHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    TriangleCullDisableBitNV = TriangleFacingCullDisableBitKHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    TriangleFrontCounterclockwiseBitNV = TriangleFrontCounterclockwiseBitKHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    ForceOpaqueBitNV = ForceOpaqueBitKHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    ForceNoOpaqueBitNV = ForceNoOpaqueBitKHR,
}
