// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

public unsafe partial struct BufferViewCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkBufferViewCreateFlags")]
    public uint Flags;

    [NativeTypeName("VkBuffer")]
    public BufferHandle Buffer;
    public Format Format;

    [NativeTypeName("VkDeviceSize")]
    public ulong Offset;

    [NativeTypeName("VkDeviceSize")]
    public ulong Range;
}
