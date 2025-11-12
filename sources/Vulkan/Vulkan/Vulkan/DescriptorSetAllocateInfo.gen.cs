// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DescriptorSetAllocateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDescriptorPool")]
    [SupportedApiProfile("vulkan")]
    public DescriptorPoolHandle DescriptorPool;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DescriptorSetCount;

    [NativeTypeName("const VkDescriptorSetLayout *")]
    [SupportedApiProfile("vulkan")]
    public DescriptorSetLayoutHandle* PSetLayouts;
}
