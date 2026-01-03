// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceHostImageCopyProperties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint CopySrcLayoutCount;
    public ImageLayout* PCopySrcLayouts;

    [NativeTypeName("uint32_t")]
    public uint CopyDstLayoutCount;
    public ImageLayout* PCopyDstLayouts;

    [NativeTypeName("uint8_t[16]")]
    public PhysicalDeviceHostImageCopyPropertiesOptimalTilingLayoutUUID OptimalTilingLayoutUUID;

    [NativeTypeName("VkBool32")]
    public uint IdenticalMemoryTypeRequirements;
}
