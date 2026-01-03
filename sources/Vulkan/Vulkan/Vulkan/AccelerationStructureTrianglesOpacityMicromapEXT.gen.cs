// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct AccelerationStructureTrianglesOpacityMicromapEXT
{
    public StructureType SType;
    public void* PNext;
    public IndexType IndexType;
    public DeviceOrHostAddressConstKHR IndexBuffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong IndexStride;

    [NativeTypeName("uint32_t")]
    public uint BaseTriangle;

    [NativeTypeName("uint32_t")]
    public uint UsageCountsCount;

    [NativeTypeName("const VkMicromapUsageEXT *")]
    public MicromapUsageEXT* PUsageCounts;

    [NativeTypeName("const VkMicromapUsageEXT *const *")]
    public MicromapUsageEXT** PpUsageCounts;

    [NativeTypeName("VkMicromapEXT")]
    public MicromapHandleEXT Micromap;
}
