// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ClusterAccelerationStructureCommandsInfoNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public ClusterAccelerationStructureInputInfoNV Input;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong DstImplicitData;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong ScratchData;

    [SupportedApiProfile("vulkan")]
    public StridedDeviceAddressRegionKHR DstAddressesArray;

    [SupportedApiProfile("vulkan")]
    public StridedDeviceAddressRegionKHR DstSizesArray;

    [SupportedApiProfile("vulkan")]
    public StridedDeviceAddressRegionKHR SrcInfosArray;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong SrcInfosCount;

    [NativeTypeName("VkClusterAccelerationStructureAddressResolutionFlagsNV")]
    [SupportedApiProfile("vulkan")]
    public ClusterAccelerationStructureAddressResolutionFlagsNV AddressResolutionFlags;
}
