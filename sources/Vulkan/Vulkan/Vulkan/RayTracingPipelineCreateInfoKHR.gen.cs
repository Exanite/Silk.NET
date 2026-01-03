// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct RayTracingPipelineCreateInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineCreateFlags")]
    public PipelineCreateFlags Flags;

    [NativeTypeName("uint32_t")]
    public uint StageCount;

    [NativeTypeName("const VkPipelineShaderStageCreateInfo *")]
    public PipelineShaderStageCreateInfo* PStages;

    [NativeTypeName("uint32_t")]
    public uint GroupCount;

    [NativeTypeName("const VkRayTracingShaderGroupCreateInfoKHR *")]
    public RayTracingShaderGroupCreateInfoKHR* PGroups;

    [NativeTypeName("uint32_t")]
    public uint MaxPipelineRayRecursionDepth;

    [NativeTypeName("const VkPipelineLibraryCreateInfoKHR *")]
    public PipelineLibraryCreateInfoKHR* PLibraryInfo;

    [NativeTypeName("const VkRayTracingPipelineInterfaceCreateInfoKHR *")]
    public RayTracingPipelineInterfaceCreateInfoKHR* PLibraryInterface;

    [NativeTypeName("const VkPipelineDynamicStateCreateInfo *")]
    public PipelineDynamicStateCreateInfo* PDynamicState;

    [NativeTypeName("VkPipelineLayout")]
    public PipelineLayoutHandle Layout;

    [NativeTypeName("VkPipeline")]
    public PipelineHandle BasePipelineHandle;

    [NativeTypeName("int32_t")]
    public int BasePipelineIndex;
}
