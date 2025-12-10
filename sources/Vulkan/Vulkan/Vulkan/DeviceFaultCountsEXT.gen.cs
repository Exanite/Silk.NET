// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DeviceFaultCountsEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint AddressInfoCount;

    [NativeTypeName("uint32_t")]
    public uint VendorInfoCount;

    [NativeTypeName("VkDeviceSize")]
    public ulong VendorBinarySize;
}
