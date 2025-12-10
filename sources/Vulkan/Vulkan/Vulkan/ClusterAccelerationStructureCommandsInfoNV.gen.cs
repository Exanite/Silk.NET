// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct ClusterAccelerationStructureCommandsInfoNV
{
    public StructureType SType;
    public void* PNext;
    public ClusterAccelerationStructureInputInfoNV Input;

    [NativeTypeName("VkDeviceAddress")]
    public ulong DstImplicitData;

    [NativeTypeName("VkDeviceAddress")]
    public ulong ScratchData;
    public StridedDeviceAddressRegionKHR DstAddressesArray;
    public StridedDeviceAddressRegionKHR DstSizesArray;
    public StridedDeviceAddressRegionKHR SrcInfosArray;

    [NativeTypeName("VkDeviceAddress")]
    public ulong SrcInfosCount;

    [NativeTypeName("VkClusterAccelerationStructureAddressResolutionFlagsNV")]
    public ClusterAccelerationStructureAddressResolutionFlagsNV AddressResolutionFlags;
}
