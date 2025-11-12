// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceHostImageCopyProperties
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CopySrcLayoutCount;

    [SupportedApiProfile("vulkan")]
    public ImageLayout* PCopySrcLayouts;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CopyDstLayoutCount;

    [SupportedApiProfile("vulkan")]
    public ImageLayout* PCopyDstLayouts;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHostImageCopyPropertiesOptimalTilingLayoutUUID OptimalTilingLayoutUUID;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> IdenticalMemoryTypeRequirements;
}
