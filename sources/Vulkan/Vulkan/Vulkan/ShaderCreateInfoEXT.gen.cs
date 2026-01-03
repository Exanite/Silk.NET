// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct ShaderCreateInfoEXT
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkShaderCreateFlagsEXT")]
    public ShaderCreateFlagsEXT Flags;
    public ShaderStageFlags Stage;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags NextStage;
    public ShaderCodeTypeEXT CodeType;

    [NativeTypeName("size_t")]
    public nuint CodeSize;

    [NativeTypeName("const void *")]
    public void* PCode;

    [NativeTypeName("const char *")]
    public sbyte* PName;

    [NativeTypeName("uint32_t")]
    public uint SetLayoutCount;

    [NativeTypeName("const VkDescriptorSetLayout *")]
    public DescriptorSetLayoutHandle* PSetLayouts;

    [NativeTypeName("uint32_t")]
    public uint PushConstantRangeCount;

    [NativeTypeName("const VkPushConstantRange *")]
    public PushConstantRange* PPushConstantRanges;

    [NativeTypeName("const VkSpecializationInfo *")]
    public SpecializationInfo* PSpecializationInfo;
}
