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
public enum QueryPipelineStatisticFlags : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    InputAssemblyVerticesBit = 0x00000001,

    [SupportedApiProfile("vulkan")]
    InputAssemblyPrimitivesBit = 0x00000002,

    [SupportedApiProfile("vulkan")]
    VertexShaderInvocationsBit = 0x00000004,

    [SupportedApiProfile("vulkan")]
    GeometryShaderInvocationsBit = 0x00000008,

    [SupportedApiProfile("vulkan")]
    GeometryShaderPrimitivesBit = 0x00000010,

    [SupportedApiProfile("vulkan")]
    ClippingInvocationsBit = 0x00000020,

    [SupportedApiProfile("vulkan")]
    ClippingPrimitivesBit = 0x00000040,

    [SupportedApiProfile("vulkan")]
    FragmentShaderInvocationsBit = 0x00000080,

    [SupportedApiProfile("vulkan")]
    TessellationControlShaderPatchesBit = 0x00000100,

    [SupportedApiProfile("vulkan")]
    TessellationEvaluationShaderInvocationsBit = 0x00000200,

    [SupportedApiProfile("vulkan")]
    ComputeShaderInvocationsBit = 0x00000400,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    TaskShaderInvocationsBitEXT = 0x00000800,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_mesh_shader"],
        ImpliesSets = ["VK_EXT_mesh_shader+VK_KHR_spirv_1_4", "VK_EXT_mesh_shader+VK_VERSION_1_2"]
    )]
    MeshShaderInvocationsBitEXT = 0x00001000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_cluster_culling_shader"],
        ImpliesSets = [
            "VK_HUAWEI_cluster_culling_shader+VK_KHR_get_physical_device_properties2",
            "VK_HUAWEI_cluster_culling_shader+VK_VERSION_1_1",
        ]
    )]
    ClusterCullingShaderInvocationsBitHuawei = 0x00002000,
}
