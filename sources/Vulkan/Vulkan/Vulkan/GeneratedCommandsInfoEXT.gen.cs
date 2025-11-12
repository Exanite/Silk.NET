// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct GeneratedCommandsInfoEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags ShaderStages;

    [NativeTypeName("VkIndirectExecutionSetEXT")]
    [SupportedApiProfile("vulkan")]
    public IndirectExecutionSetEXTHandle IndirectExecutionSet;

    [NativeTypeName("VkIndirectCommandsLayoutEXT")]
    [SupportedApiProfile("vulkan")]
    public IndirectCommandsLayoutEXTHandle IndirectCommandsLayout;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong IndirectAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong IndirectAddressSize;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong PreprocessAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong PreprocessSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxSequenceCount;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong SequenceCountAddress;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDrawCount;
}
