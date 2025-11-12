// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct AccelerationStructureBuildGeometryInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public AccelerationStructureTypeKHR Type;

    [NativeTypeName("VkBuildAccelerationStructureFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public BuildAccelerationStructureFlagsKHR Flags;

    [SupportedApiProfile("vulkan")]
    public BuildAccelerationStructureModeKHR Mode;

    [NativeTypeName("VkAccelerationStructureKHR")]
    [SupportedApiProfile("vulkan")]
    public AccelerationStructureKHRHandle SrcAccelerationStructure;

    [NativeTypeName("VkAccelerationStructureKHR")]
    [SupportedApiProfile("vulkan")]
    public AccelerationStructureKHRHandle DstAccelerationStructure;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint GeometryCount;

    [NativeTypeName("const VkAccelerationStructureGeometryKHR *")]
    [SupportedApiProfile("vulkan")]
    public AccelerationStructureGeometryKHR* PGeometries;

    [NativeTypeName("const VkAccelerationStructureGeometryKHR *const *")]
    [SupportedApiProfile("vulkan")]
    public AccelerationStructureGeometryKHR** PpGeometries;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressKHR ScratchData;
}
