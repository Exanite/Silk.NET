// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct GraphicsPipelineCreateInfo
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

    [NativeTypeName("const VkPipelineVertexInputStateCreateInfo *")]
    public PipelineVertexInputStateCreateInfo* PVertexInputState;

    [NativeTypeName("const VkPipelineInputAssemblyStateCreateInfo *")]
    public PipelineInputAssemblyStateCreateInfo* PInputAssemblyState;

    [NativeTypeName("const VkPipelineTessellationStateCreateInfo *")]
    public PipelineTessellationStateCreateInfo* PTessellationState;

    [NativeTypeName("const VkPipelineViewportStateCreateInfo *")]
    public PipelineViewportStateCreateInfo* PViewportState;

    [NativeTypeName("const VkPipelineRasterizationStateCreateInfo *")]
    public PipelineRasterizationStateCreateInfo* PRasterizationState;

    [NativeTypeName("const VkPipelineMultisampleStateCreateInfo *")]
    public PipelineMultisampleStateCreateInfo* PMultisampleState;

    [NativeTypeName("const VkPipelineDepthStencilStateCreateInfo *")]
    public PipelineDepthStencilStateCreateInfo* PDepthStencilState;

    [NativeTypeName("const VkPipelineColorBlendStateCreateInfo *")]
    public PipelineColorBlendStateCreateInfo* PColorBlendState;

    [NativeTypeName("const VkPipelineDynamicStateCreateInfo *")]
    public PipelineDynamicStateCreateInfo* PDynamicState;

    [NativeTypeName("VkPipelineLayout")]
    public PipelineLayoutHandle Layout;

    [NativeTypeName("VkRenderPass")]
    public RenderPassHandle RenderPass;

    [NativeTypeName("uint32_t")]
    public uint Subpass;

    [NativeTypeName("VkPipeline")]
    public PipelineHandle BasePipelineHandle;

    [NativeTypeName("int32_t")]
    public int BasePipelineIndex;
}
