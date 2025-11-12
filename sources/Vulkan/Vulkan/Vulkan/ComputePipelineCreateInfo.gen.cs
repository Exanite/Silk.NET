// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ComputePipelineCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public PipelineCreateFlags Flags;

    [SupportedApiProfile("vulkan")]
    public PipelineShaderStageCreateInfo Stage;

    [NativeTypeName("VkPipelineLayout")]
    [SupportedApiProfile("vulkan")]
    public PipelineLayoutHandle Layout;

    [NativeTypeName("VkPipeline")]
    [SupportedApiProfile("vulkan")]
    public PipelineHandle BasePipelineHandle;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int BasePipelineIndex;
}
