// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct AccelerationStructureBuildGeometryInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;
    public AccelerationStructureTypeKHR Type;

    [NativeTypeName("VkBuildAccelerationStructureFlagsKHR")]
    public BuildAccelerationStructureFlagsKHR Flags;
    public BuildAccelerationStructureModeKHR Mode;

    [NativeTypeName("VkAccelerationStructureKHR")]
    public AccelerationStructureHandleKHR SrcAccelerationStructure;

    [NativeTypeName("VkAccelerationStructureKHR")]
    public AccelerationStructureHandleKHR DstAccelerationStructure;

    [NativeTypeName("uint32_t")]
    public uint GeometryCount;

    [NativeTypeName("const VkAccelerationStructureGeometryKHR *")]
    public AccelerationStructureGeometryKHR* PGeometries;

    [NativeTypeName("const VkAccelerationStructureGeometryKHR *const *")]
    public AccelerationStructureGeometryKHR** PpGeometries;
    public DeviceOrHostAddressKHR ScratchData;
}
