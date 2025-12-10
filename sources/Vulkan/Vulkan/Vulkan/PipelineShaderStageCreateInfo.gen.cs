// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineShaderStageCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineShaderStageCreateFlags")]
    public PipelineShaderStageCreateFlags Flags;
    public ShaderStageFlags Stage;

    [NativeTypeName("VkShaderModule")]
    public ShaderModuleHandle Module;

    [NativeTypeName("const char *")]
    public sbyte* PName;

    [NativeTypeName("const VkSpecializationInfo *")]
    public SpecializationInfo* PSpecializationInfo;
}
