// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MaxIndirectPipelineCount;

    [NativeTypeName("uint32_t")]
    public uint MaxIndirectShaderObjectCount;

    [NativeTypeName("uint32_t")]
    public uint MaxIndirectSequenceCount;

    [NativeTypeName("uint32_t")]
    public uint MaxIndirectCommandsTokenCount;

    [NativeTypeName("uint32_t")]
    public uint MaxIndirectCommandsTokenOffset;

    [NativeTypeName("uint32_t")]
    public uint MaxIndirectCommandsIndirectStride;

    [NativeTypeName("VkIndirectCommandsInputModeFlagsEXT")]
    public IndirectCommandsInputModeFlagsEXT SupportedIndirectCommandsInputModes;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags SupportedIndirectCommandsShaderStages;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags SupportedIndirectCommandsShaderStagesPipelineBinding;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags SupportedIndirectCommandsShaderStagesShaderBinding;

    [NativeTypeName("VkBool32")]
    public uint DeviceGeneratedCommandsTransformFeedback;

    [NativeTypeName("VkBool32")]
    public uint DeviceGeneratedCommandsMultiDrawIndirectCount;
}
