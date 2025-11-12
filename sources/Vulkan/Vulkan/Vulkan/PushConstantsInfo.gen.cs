// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PushConstantsInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineLayout")]
    [SupportedApiProfile("vulkan")]
    public PipelineLayoutHandle Layout;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags StageFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Offset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Size;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PValues;
}
