// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct GeometryTrianglesNV
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkBuffer")]
    public BufferHandle VertexData;

    [NativeTypeName("VkDeviceSize")]
    public ulong VertexOffset;

    [NativeTypeName("uint32_t")]
    public uint VertexCount;

    [NativeTypeName("VkDeviceSize")]
    public ulong VertexStride;
    public Format VertexFormat;

    [NativeTypeName("VkBuffer")]
    public BufferHandle IndexData;

    [NativeTypeName("VkDeviceSize")]
    public ulong IndexOffset;

    [NativeTypeName("uint32_t")]
    public uint IndexCount;
    public IndexType IndexType;

    [NativeTypeName("VkBuffer")]
    public BufferHandle TransformData;

    [NativeTypeName("VkDeviceSize")]
    public ulong TransformOffset;
}
