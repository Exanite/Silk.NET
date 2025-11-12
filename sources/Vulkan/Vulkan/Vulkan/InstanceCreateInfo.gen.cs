// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct InstanceCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkInstanceCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public InstanceCreateFlags Flags;

    [NativeTypeName("const VkApplicationInfo *")]
    [SupportedApiProfile("vulkan")]
    public ApplicationInfo* PApplicationInfo;

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
}
