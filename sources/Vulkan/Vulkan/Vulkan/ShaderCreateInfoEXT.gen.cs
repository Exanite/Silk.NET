// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ShaderCreateInfoEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkShaderCreateFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public ShaderCreateFlagsEXT Flags;

    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags Stage;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags NextStage;

    [SupportedApiProfile("vulkan")]
    public ShaderCodeTypeEXT CodeType;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint CodeSize;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PCode;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan")]
    public sbyte* PName;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SetLayoutCount;

    [NativeTypeName("const VkDescriptorSetLayout *")]
    [SupportedApiProfile("vulkan")]
    public DescriptorSetLayoutHandle* PSetLayouts;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PushConstantRangeCount;

    [NativeTypeName("const VkPushConstantRange *")]
    [SupportedApiProfile("vulkan")]
    public PushConstantRange* PPushConstantRanges;

    [NativeTypeName("const VkSpecializationInfo *")]
    [SupportedApiProfile("vulkan")]
    public SpecializationInfo* PSpecializationInfo;
}
