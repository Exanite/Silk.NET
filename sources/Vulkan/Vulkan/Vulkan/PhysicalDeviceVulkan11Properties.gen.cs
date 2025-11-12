// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceVulkan11Properties
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceVulkan11PropertiesDeviceUUID DeviceUUID;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceVulkan11PropertiesDriverUUID DriverUUID;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceVulkan11PropertiesDeviceLUID DeviceLUID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DeviceNodeMask;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> DeviceLUIDValid;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SubgroupSize;

    [NativeTypeName("VkShaderStageFlags")]
    [SupportedApiProfile("vulkan")]
    public ShaderStageFlags SubgroupSupportedStages;

    [NativeTypeName("VkSubgroupFeatureFlags")]
    [SupportedApiProfile("vulkan")]
    public SubgroupFeatureFlags SubgroupSupportedOperations;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> SubgroupQuadOperationsInAllStages;

    [SupportedApiProfile("vulkan")]
    public PointClippingBehavior PointClippingBehavior;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMultiviewViewCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMultiviewInstanceIndex;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ProtectedNoFault;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerSetDescriptors;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxMemoryAllocationSize;
}
