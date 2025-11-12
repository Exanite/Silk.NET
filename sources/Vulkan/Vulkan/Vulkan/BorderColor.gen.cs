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
public enum BorderColor : uint
{
    [SupportedApiProfile("vulkan")]
    FloatTransparentBlack = 0,

    [SupportedApiProfile("vulkan")]
    IntTransparentBlack = 1,

    [SupportedApiProfile("vulkan")]
    FloatOpaqueBlack = 2,

    [SupportedApiProfile("vulkan")]
    IntOpaqueBlack = 3,

    [SupportedApiProfile("vulkan")]
    FloatOpaqueWhite = 4,

    [SupportedApiProfile("vulkan")]
    IntOpaqueWhite = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    FloatCustomEXT = 1000287003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_custom_border_color"],
        ImpliesSets = [
            "VK_EXT_custom_border_color+VK_KHR_get_physical_device_properties2",
            "VK_EXT_custom_border_color+VK_VERSION_1_1",
        ]
    )]
    IntCustomEXT = 1000287004,
}
