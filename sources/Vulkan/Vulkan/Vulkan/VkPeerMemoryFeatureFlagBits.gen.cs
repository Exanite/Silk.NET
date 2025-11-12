// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum PeerMemoryFeatureFlags : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    CopySrcBit = 0x00000001,

    [SupportedApiProfile("vulkan")]
    CopyDstBit = 0x00000002,

    [SupportedApiProfile("vulkan")]
    GenericSrcBit = 0x00000004,

    [SupportedApiProfile("vulkan")]
    GenericDstBit = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    CopySrcBitKHR = CopySrcBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    CopyDstBitKHR = CopyDstBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    GenericSrcBitKHR = GenericSrcBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    GenericDstBitKHR = GenericDstBit,
}
