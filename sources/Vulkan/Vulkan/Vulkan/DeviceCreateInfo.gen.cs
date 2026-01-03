// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DeviceCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkDeviceCreateFlags")]
    public uint Flags;

    [NativeTypeName("uint32_t")]
    public uint QueueCreateInfoCount;

    [NativeTypeName("const VkDeviceQueueCreateInfo *")]
    public DeviceQueueCreateInfo* PQueueCreateInfos;

    [NativeTypeName("uint32_t")]
    public uint EnabledLayerCount;

    [NativeTypeName("const char *const *")]
    public sbyte** PpEnabledLayerNames;

    [NativeTypeName("uint32_t")]
    public uint EnabledExtensionCount;

    [NativeTypeName("const char *const *")]
    public sbyte** PpEnabledExtensionNames;

    [NativeTypeName("const VkPhysicalDeviceFeatures *")]
    public PhysicalDeviceFeatures* PEnabledFeatures;
}
