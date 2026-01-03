// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct DescriptorPoolCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkDescriptorPoolCreateFlags")]
    public DescriptorPoolCreateFlags Flags;

    [NativeTypeName("uint32_t")]
    public uint MaxSets;

    [NativeTypeName("uint32_t")]
    public uint PoolSizeCount;

    [NativeTypeName("const VkDescriptorPoolSize *")]
    public DescriptorPoolSize* PPoolSizes;
}
