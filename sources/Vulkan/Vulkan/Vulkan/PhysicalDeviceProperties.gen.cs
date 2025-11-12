// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct PhysicalDeviceProperties
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ApiVersion;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DriverVersion;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VendorID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DeviceID;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceType DeviceType;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevicePropertiesDeviceName DeviceName;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevicePropertiesPipelineCacheUUID PipelineCacheUUID;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceLimits Limits;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceSparseProperties SparseProperties;
}
