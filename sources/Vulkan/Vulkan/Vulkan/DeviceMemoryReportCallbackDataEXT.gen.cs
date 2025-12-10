// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DeviceMemoryReportCallbackDataEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkDeviceMemoryReportFlagsEXT")]
    public uint Flags;
    public DeviceMemoryReportEventTypeEXT Type;

    [NativeTypeName("uint64_t")]
    public ulong MemoryObjectId;

    [NativeTypeName("VkDeviceSize")]
    public ulong Size;
    public ObjectType ObjectType;

    [NativeTypeName("uint64_t")]
    public ulong ObjectHandle;

    [NativeTypeName("uint32_t")]
    public uint HeapIndex;
}
