// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct CopyBufferInfo2
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkBuffer")]
    public BufferHandle SrcBuffer;

    [NativeTypeName("VkBuffer")]
    public BufferHandle DstBuffer;

    [NativeTypeName("uint32_t")]
    public uint RegionCount;

    [NativeTypeName("const VkBufferCopy2 *")]
    public BufferCopy2* PRegions;
}
