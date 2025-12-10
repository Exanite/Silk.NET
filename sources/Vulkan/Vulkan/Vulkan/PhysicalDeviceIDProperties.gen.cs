// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceIDProperties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint8_t[16]")]
    public PhysicalDeviceIDPropertiesDeviceUUID DeviceUUID;

    [NativeTypeName("uint8_t[16]")]
    public PhysicalDeviceIDPropertiesDriverUUID DriverUUID;

    [NativeTypeName("uint8_t[8]")]
    public PhysicalDeviceIDPropertiesDeviceLUID DeviceLUID;

    [NativeTypeName("uint32_t")]
    public uint DeviceNodeMask;

    [NativeTypeName("VkBool32")]
    public uint DeviceLUIDValid;
}
