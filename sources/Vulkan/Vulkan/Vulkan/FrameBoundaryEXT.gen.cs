// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct FrameBoundaryEXT
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkFrameBoundaryFlagsEXT")]
    public FrameBoundaryFlagsEXT Flags;

    [NativeTypeName("uint64_t")]
    public ulong FrameID;

    [NativeTypeName("uint32_t")]
    public uint ImageCount;

    [NativeTypeName("const VkImage *")]
    public ImageHandle* PImages;

    [NativeTypeName("uint32_t")]
    public uint BufferCount;

    [NativeTypeName("const VkBuffer *")]
    public BufferHandle* PBuffers;

    [NativeTypeName("uint64_t")]
    public ulong TagName;

    [NativeTypeName("size_t")]
    public nuint TagSize;

    [NativeTypeName("const void *")]
    public void* PTag;
}
