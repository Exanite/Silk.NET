// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct AccelerationStructureGeometrySpheresDataNV
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;
    public Format VertexFormat;
    public DeviceOrHostAddressConstKHR VertexData;

    [NativeTypeName("VkDeviceSize")]
    public ulong VertexStride;
    public Format RadiusFormat;
    public DeviceOrHostAddressConstKHR RadiusData;

    [NativeTypeName("VkDeviceSize")]
    public ulong RadiusStride;
    public IndexType IndexType;
    public DeviceOrHostAddressConstKHR IndexData;

    [NativeTypeName("VkDeviceSize")]
    public ulong IndexStride;
}
