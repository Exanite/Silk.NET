// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DescriptorSetLayoutBinding
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Binding;

    [SupportedApiProfile("vulkan")]
    public DescriptorType DescriptorType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DescriptorCount;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags StageFlags;

    [NativeTypeName("const VkSampler *")]
    [SupportedApiProfile("vulkan")]
    public SamplerHandle* PImmutableSamplers;
}
