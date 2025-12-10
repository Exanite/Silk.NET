// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct AccelerationStructureCreateInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkAccelerationStructureCreateFlagsKHR")]
    public AccelerationStructureCreateFlagsKHR CreateFlags;

    [NativeTypeName("VkBuffer")]
    public BufferHandle Buffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong Offset;

    [NativeTypeName("VkDeviceSize")]
    public ulong Size;
    public AccelerationStructureTypeKHR Type;

    [NativeTypeName("VkDeviceAddress")]
    public ulong DeviceAddress;
}
