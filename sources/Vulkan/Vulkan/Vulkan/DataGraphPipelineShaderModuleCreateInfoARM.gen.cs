// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DataGraphPipelineShaderModuleCreateInfoARM
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkShaderModule")]
    public ShaderModuleHandle Module;

    [NativeTypeName("const char *")]
    public sbyte* PName;

    [NativeTypeName("const VkSpecializationInfo *")]
    public SpecializationInfo* PSpecializationInfo;

    [NativeTypeName("uint32_t")]
    public uint ConstantCount;

    [NativeTypeName("const VkDataGraphPipelineConstantARM *")]
    public DataGraphPipelineConstantARM* PConstants;
}
