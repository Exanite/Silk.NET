// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct AccelerationStructureGeometrySpheresDataNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public Format VertexFormat;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressConstKHR VertexData;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong VertexStride;

    [SupportedApiProfile("vulkan")]
    public Format RadiusFormat;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressConstKHR RadiusData;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong RadiusStride;

    [SupportedApiProfile("vulkan")]
    public IndexType IndexType;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressConstKHR IndexData;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong IndexStride;
}
