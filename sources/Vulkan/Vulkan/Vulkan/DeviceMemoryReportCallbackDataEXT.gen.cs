// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DeviceMemoryReportCallbackDataEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDeviceMemoryReportFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [SupportedApiProfile("vulkan")]
    public DeviceMemoryReportEventTypeEXT Type;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MemoryObjectId;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong Size;

    [SupportedApiProfile("vulkan")]
    public ObjectType ObjectType;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong ObjectHandle;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint HeapIndex;
}
