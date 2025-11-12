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
public enum ResolveModeFlags : uint
{
    [SupportedApiProfile("vulkan")]
    None = 0,

    [SupportedApiProfile("vulkan")]
    SampleZeroBit = 0x00000001,

    [SupportedApiProfile("vulkan")]
    AverageBit = 0x00000002,

    [SupportedApiProfile("vulkan")]
    MinBit = 0x00000004,

    [SupportedApiProfile("vulkan")]
    MaxBit = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_format_resolve+VK_KHR_dynamic_rendering",
            "VK_ANDROID_external_format_resolve+VK_VERSION_1_3",
        ],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    ExternalFormatDownsampleBitAndroid = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    NoneKHR = None,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    SampleZeroBitKHR = SampleZeroBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    AverageBitKHR = AverageBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    MinBitKHR = MinBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    MaxBitKHR = MaxBit,
}
