// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct PartitionedAccelerationStructureWriteInstanceDataNV
{
    public TransformMatrixKHR Transform;

    [NativeTypeName("float[6]")]
    public PartitionedAccelerationStructureWriteInstanceDataNVExplicitAABB ExplicitAABB;

    [NativeTypeName("uint32_t")]
    public uint InstanceID;

    [NativeTypeName("uint32_t")]
    public uint InstanceMask;

    [NativeTypeName("uint32_t")]
    public uint InstanceContributionToHitGroupIndex;

    [NativeTypeName("VkPartitionedAccelerationStructureInstanceFlagsNV")]
    public PartitionedAccelerationStructureInstanceFlagsNV InstanceFlags;

    [NativeTypeName("uint32_t")]
    public uint InstanceIndex;

    [NativeTypeName("uint32_t")]
    public uint PartitionIndex;

    [NativeTypeName("VkDeviceAddress")]
    public ulong AccelerationStructure;
}
