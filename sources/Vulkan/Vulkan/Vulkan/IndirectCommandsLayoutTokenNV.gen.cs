// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct IndirectCommandsLayoutTokenNV
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;
    public IndirectCommandsTokenTypeNV TokenType;

    [NativeTypeName("uint32_t")]
    public uint Stream;

    [NativeTypeName("uint32_t")]
    public uint Offset;

    [NativeTypeName("uint32_t")]
    public uint VertexBindingUnit;

    [NativeTypeName("VkBool32")]
    public uint VertexDynamicStride;

    [NativeTypeName("VkPipelineLayout")]
    public PipelineLayoutHandle PushconstantPipelineLayout;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags PushconstantShaderStageFlags;

    [NativeTypeName("uint32_t")]
    public uint PushconstantOffset;

    [NativeTypeName("uint32_t")]
    public uint PushconstantSize;

    [NativeTypeName("VkIndirectStateFlagsNV")]
    public IndirectStateFlagsNV IndirectStateFlags;

    [NativeTypeName("uint32_t")]
    public uint IndexTypeCount;

    [NativeTypeName("const VkIndexType *")]
    public IndexType* PIndexTypes;

    [NativeTypeName("const uint32_t *")]
    public uint* PIndexTypeValues;
}
