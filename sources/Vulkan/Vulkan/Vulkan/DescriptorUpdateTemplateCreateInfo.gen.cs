// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DescriptorUpdateTemplateCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDescriptorUpdateTemplateCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DescriptorUpdateEntryCount;

    [NativeTypeName("const VkDescriptorUpdateTemplateEntry *")]
    [SupportedApiProfile("vulkan")]
    public DescriptorUpdateTemplateEntry* PDescriptorUpdateEntries;

    [SupportedApiProfile("vulkan")]
    public DescriptorUpdateTemplateType TemplateType;

    [NativeTypeName("VkDescriptorSetLayout")]
    [SupportedApiProfile("vulkan")]
    public DescriptorSetLayoutHandle DescriptorSetLayout;

    [SupportedApiProfile("vulkan")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeTypeName("VkPipelineLayout")]
    [SupportedApiProfile("vulkan")]
    public PipelineLayoutHandle PipelineLayout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Set;
}
