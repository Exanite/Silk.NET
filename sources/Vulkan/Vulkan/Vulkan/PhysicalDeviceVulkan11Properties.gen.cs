// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceVulkan11Properties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint8_t[16]")]
    public PhysicalDeviceVulkan11PropertiesDeviceUUID DeviceUUID;

    [NativeTypeName("uint8_t[16]")]
    public PhysicalDeviceVulkan11PropertiesDriverUUID DriverUUID;

    [NativeTypeName("uint8_t[8]")]
    public PhysicalDeviceVulkan11PropertiesDeviceLUID DeviceLUID;

    [NativeTypeName("uint32_t")]
    public uint DeviceNodeMask;

    [NativeTypeName("VkBool32")]
    public uint DeviceLUIDValid;

    [NativeTypeName("uint32_t")]
    public uint SubgroupSize;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags SubgroupSupportedStages;

    [NativeTypeName("VkSubgroupFeatureFlags")]
    public SubgroupFeatureFlags SubgroupSupportedOperations;

    [NativeTypeName("VkBool32")]
    public uint SubgroupQuadOperationsInAllStages;
    public PointClippingBehavior PointClippingBehavior;

    [NativeTypeName("uint32_t")]
    public uint MaxMultiviewViewCount;

    [NativeTypeName("uint32_t")]
    public uint MaxMultiviewInstanceIndex;

    [NativeTypeName("VkBool32")]
    public uint ProtectedNoFault;

    [NativeTypeName("uint32_t")]
    public uint MaxPerSetDescriptors;

    [NativeTypeName("VkDeviceSize")]
    public ulong MaxMemoryAllocationSize;
}
