// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct AccelerationStructureGeometryTrianglesDataKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;
    public Format VertexFormat;
    public DeviceOrHostAddressConstKHR VertexData;

    [NativeTypeName("VkDeviceSize")]
    public ulong VertexStride;

    [NativeTypeName("uint32_t")]
    public uint MaxVertex;
    public IndexType IndexType;
    public DeviceOrHostAddressConstKHR IndexData;
    public DeviceOrHostAddressConstKHR TransformData;
}
