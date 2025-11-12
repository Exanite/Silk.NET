// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DeviceCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDeviceCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueCreateInfoCount;

    [NativeTypeName("const VkDeviceQueueCreateInfo *")]
    [SupportedApiProfile("vulkan")]
    public DeviceQueueCreateInfo* PQueueCreateInfos;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint EnabledLayerCount;

    [NativeTypeName("const char *const *")]
    [SupportedApiProfile("vulkan")]
    public sbyte** PpEnabledLayerNames;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint EnabledExtensionCount;

    [NativeTypeName("const char *const *")]
    [SupportedApiProfile("vulkan")]
    public sbyte** PpEnabledExtensionNames;

    [NativeTypeName("const VkPhysicalDeviceFeatures *")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceFeatures* PEnabledFeatures;
}
