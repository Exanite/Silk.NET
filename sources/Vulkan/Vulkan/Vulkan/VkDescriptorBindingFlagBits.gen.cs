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
public enum DescriptorBindingFlags : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    UpdateAfterBindBit = 0x00000001,

    [SupportedApiProfile("vulkan")]
    UpdateUnusedWhilePendingBit = 0x00000002,

    [SupportedApiProfile("vulkan")]
    PartiallyBoundBit = 0x00000004,

    [SupportedApiProfile("vulkan")]
    VariableDescriptorCountBit = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    UpdateAfterBindBitEXT = UpdateAfterBindBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    UpdateUnusedWhilePendingBitEXT = UpdateUnusedWhilePendingBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    PartiallyBoundBitEXT = PartiallyBoundBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_indexing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_maintenance3",
            "VK_VERSION_1_1",
        ]
    )]
    VariableDescriptorCountBitEXT = VariableDescriptorCountBit,
}
