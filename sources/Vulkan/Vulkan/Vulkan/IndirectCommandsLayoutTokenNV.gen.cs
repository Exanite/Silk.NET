// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct IndirectCommandsLayoutTokenNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public IndirectCommandsTokenTypeNV TokenType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Stream;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Offset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VertexBindingUnit;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> VertexDynamicStride;

    [NativeTypeName("VkPipelineLayout")]
    [SupportedApiProfile("vulkan")]
    public PipelineLayoutHandle PushconstantPipelineLayout;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags PushconstantShaderStageFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PushconstantOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PushconstantSize;

    [NativeTypeName("VkIndirectStateFlagsNV")]
    [SupportedApiProfile("vulkan")]
    public IndirectStateFlagsNV IndirectStateFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint IndexTypeCount;

    [NativeTypeName("const VkIndexType *")]
    [SupportedApiProfile("vulkan")]
    public IndexType* PIndexTypes;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PIndexTypeValues;
}
