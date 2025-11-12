// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct MicromapBuildInfoEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public MicromapTypeEXT Type;

    [NativeTypeName("VkBuildMicromapFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public BuildMicromapFlagsEXT Flags;

    [SupportedApiProfile("vulkan")]
    public BuildMicromapModeEXT Mode;

    [NativeTypeName("VkMicromapEXT")]
    [SupportedApiProfile("vulkan")]
    public MicromapEXTHandle DstMicromap;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint UsageCountsCount;

    [NativeTypeName("const VkMicromapUsageEXT *")]
    [SupportedApiProfile("vulkan")]
    public MicromapUsageEXT* PUsageCounts;

    [NativeTypeName("const VkMicromapUsageEXT *const *")]
    [SupportedApiProfile("vulkan")]
    public MicromapUsageEXT** PpUsageCounts;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressConstKHR Data;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressKHR ScratchData;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressConstKHR TriangleArray;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong TriangleArrayStride;
}
