// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineColorBlendStateCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineColorBlendStateCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public PipelineColorBlendStateCreateFlags Flags;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> LogicOpEnable;

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_extended_dynamic_state3",
            "VkPhysicalDeviceExtendedDynamicState3FeaturesEXT::extendedDynamicState3LogicOpEnable",
        ],
        ImpliesSets = [
            "VK_EXT_extended_dynamic_state3+VK_KHR_get_physical_device_properties2",
            "VK_EXT_extended_dynamic_state3+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public LogicOp LogicOp;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint AttachmentCount;

    [NativeTypeName("const VkPipelineColorBlendAttachmentState *")]
    [SupportedApiProfile("vulkan")]
    public PipelineColorBlendAttachmentState* PAttachments;

    [NativeTypeName("float[4]")]
    [SupportedApiProfile("vulkan")]
    public PipelineColorBlendStateCreateInfoBlendConstants BlendConstants;
}
