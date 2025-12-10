// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DescriptorSetAllocateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkDescriptorPool")]
    public DescriptorPoolHandle DescriptorPool;

    [NativeTypeName("uint32_t")]
    public uint DescriptorSetCount;

    [NativeTypeName("const VkDescriptorSetLayout *")]
    public DescriptorSetLayoutHandle* PSetLayouts;
}
