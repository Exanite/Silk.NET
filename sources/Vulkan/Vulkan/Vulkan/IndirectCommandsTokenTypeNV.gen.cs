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
public enum IndirectCommandsTokenTypeNV : uint
{
    [SupportedApiProfile("vulkan")]
    ShaderGroupNV = 0,

    [SupportedApiProfile("vulkan")]
    StateFlagsNV = 1,

    [SupportedApiProfile("vulkan")]
    IndexBufferNV = 2,

    [SupportedApiProfile("vulkan")]
    VertexBufferNV = 3,

    [SupportedApiProfile("vulkan")]
    PushConstantNV = 4,

    [SupportedApiProfile("vulkan")]
    DrawIndexedNV = 5,

    [SupportedApiProfile("vulkan")]
    DrawNV = 6,

    [SupportedApiProfile("vulkan")]
    DrawTasksNV = 7,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader", "VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"],
        RequireAll = true
    )]
    DrawMeshTasksNV = 1000328000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    PipelineNV = 1000428003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands_compute"],
        ImpliesSets = ["VK_NV_device_generated_commands"]
    )]
    DispatchNV = 1000428004,
}
