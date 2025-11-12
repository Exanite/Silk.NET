// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceAccelerationStructurePropertiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxGeometryCount;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxInstanceCount;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxPrimitiveCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorAccelerationStructures;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetAccelerationStructures;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinAccelerationStructureScratchOffsetAlignment;
}
