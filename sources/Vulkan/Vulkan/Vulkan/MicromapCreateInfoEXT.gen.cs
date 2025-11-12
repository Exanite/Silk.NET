// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct MicromapCreateInfoEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkMicromapCreateFlagsEXT")]
    [SupportedApiProfile("vulkan")]
    public MicromapCreateFlagsEXT CreateFlags;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan")]
    public BufferHandle Buffer;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong Offset;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong Size;

    [SupportedApiProfile("vulkan")]
    public MicromapTypeEXT Type;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile("vulkan")]
    public ulong DeviceAddress;
}
