// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct GraphicsPipelineCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public PipelineCreateFlags Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint StageCount;

    [NativeTypeName("const VkPipelineShaderStageCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineShaderStageCreateInfo* PStages;

    [NativeTypeName("const VkPipelineVertexInputStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineVertexInputStateCreateInfo* PVertexInputState;

    [NativeTypeName("const VkPipelineInputAssemblyStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineInputAssemblyStateCreateInfo* PInputAssemblyState;

    [NativeTypeName("const VkPipelineTessellationStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineTessellationStateCreateInfo* PTessellationState;

    [NativeTypeName("const VkPipelineViewportStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineViewportStateCreateInfo* PViewportState;

    [NativeTypeName("const VkPipelineRasterizationStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineRasterizationStateCreateInfo* PRasterizationState;

    [NativeTypeName("const VkPipelineMultisampleStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineMultisampleStateCreateInfo* PMultisampleState;

    [NativeTypeName("const VkPipelineDepthStencilStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineDepthStencilStateCreateInfo* PDepthStencilState;

    [NativeTypeName("const VkPipelineColorBlendStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineColorBlendStateCreateInfo* PColorBlendState;

    [NativeTypeName("const VkPipelineDynamicStateCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public PipelineDynamicStateCreateInfo* PDynamicState;

    [NativeTypeName("VkPipelineLayout")]
    [SupportedApiProfile("vulkan")]
    public PipelineLayoutHandle Layout;

    [NativeTypeName("VkRenderPass")]
    [SupportedApiProfile("vulkan")]
    public RenderPassHandle RenderPass;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Subpass;

    [NativeTypeName("VkPipeline")]
    [SupportedApiProfile("vulkan")]
    public PipelineHandle BasePipelineHandle;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int BasePipelineIndex;
}
