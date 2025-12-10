// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct IndirectCommandsLayoutCreateInfoEXT
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkIndirectCommandsLayoutUsageFlagsEXT")]
    public IndirectCommandsLayoutUsageFlagsEXT Flags;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags ShaderStages;

    [NativeTypeName("uint32_t")]
    public uint IndirectStride;

    [NativeTypeName("VkPipelineLayout")]
    public PipelineLayoutHandle PipelineLayout;

    [NativeTypeName("uint32_t")]
    public uint TokenCount;

    [NativeTypeName("const VkIndirectCommandsLayoutTokenEXT *")]
    public IndirectCommandsLayoutTokenEXT* PTokens;
}
