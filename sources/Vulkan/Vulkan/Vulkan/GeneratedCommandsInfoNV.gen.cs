// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct GeneratedCommandsInfoNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeTypeName("VkPipeline")]
    [SupportedApiProfile("vulkan")]
    public PipelineHandle Pipeline;

    [NativeTypeName("VkIndirectCommandsLayoutNV")]
    [SupportedApiProfile("vulkan")]
    public IndirectCommandsLayoutNVHandle IndirectCommandsLayout;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint StreamCount;

    [NativeTypeName("const VkIndirectCommandsStreamNV *")]
    [SupportedApiProfile("vulkan")]
    public IndirectCommandsStreamNV* PStreams;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SequencesCount;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan")]
    public BufferHandle PreprocessBuffer;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong PreprocessOffset;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong PreprocessSize;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan")]
    public BufferHandle SequencesCountBuffer;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong SequencesCountOffset;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan")]
    public BufferHandle SequencesIndexBuffer;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong SequencesIndexOffset;
}
