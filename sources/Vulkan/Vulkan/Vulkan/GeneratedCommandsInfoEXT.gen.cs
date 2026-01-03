// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct GeneratedCommandsInfoEXT
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags ShaderStages;

    [NativeTypeName("VkIndirectExecutionSetEXT")]
    public IndirectExecutionSetHandleEXT IndirectExecutionSet;

    [NativeTypeName("VkIndirectCommandsLayoutEXT")]
    public IndirectCommandsLayoutHandleEXT IndirectCommandsLayout;

    [NativeTypeName("VkDeviceAddress")]
    public ulong IndirectAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong IndirectAddressSize;

    [NativeTypeName("VkDeviceAddress")]
    public ulong PreprocessAddress;

    [NativeTypeName("VkDeviceSize")]
    public ulong PreprocessSize;

    [NativeTypeName("uint32_t")]
    public uint MaxSequenceCount;

    [NativeTypeName("VkDeviceAddress")]
    public ulong SequenceCountAddress;

    [NativeTypeName("uint32_t")]
    public uint MaxDrawCount;
}
