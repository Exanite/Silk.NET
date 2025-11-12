// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct PhysicalDeviceMemoryProperties
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MemoryTypeCount;

    [NativeTypeName("VkMemoryType[32]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceMemoryPropertiesMemoryTypes MemoryTypes;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MemoryHeapCount;

    [NativeTypeName("VkMemoryHeap[16]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceMemoryPropertiesMemoryHeaps MemoryHeaps;
}
