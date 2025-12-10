// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct ClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV
{
    [NativeTypeName("uint32_t")]
    public uint ClusterID;

    [NativeTypeName("VkClusterAccelerationStructureClusterFlagsNV")]
    public ClusterAccelerationStructureClusterFlagsNV ClusterFlags;
    public uint Bitfield;

    [NativeTypeName("uint32_t : 9")]
    public uint TriangleCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~0x1FFu) | (value & 0x1FFu); }
    }

    [NativeTypeName("uint32_t : 9")]
    public uint VertexCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 9) & 0x1FFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x1FFu << 9)) | ((value & 0x1FFu) << 9); }
    }

    [NativeTypeName("uint32_t : 6")]
    public uint PositionTruncateBitCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 18) & 0x3Fu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0x3Fu << 18)) | ((value & 0x3Fu) << 18); }
    }

    [NativeTypeName("uint32_t : 4")]
    public uint IndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 24) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFu << 24)) | ((value & 0xFu) << 24); }
    }

    [NativeTypeName("uint32_t : 4")]
    public uint OpacityMicromapIndexType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield >> 28) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield = (Bitfield & ~(0xFu << 28)) | ((value & 0xFu) << 28); }
    }
    public ClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV BaseGeometryIndexAndGeometryFlags;

    [NativeTypeName("uint16_t")]
    public ushort IndexBufferStride;

    [NativeTypeName("uint16_t")]
    public ushort VertexBufferStride;

    [NativeTypeName("uint16_t")]
    public ushort GeometryIndexAndFlagsBufferStride;

    [NativeTypeName("uint16_t")]
    public ushort OpacityMicromapIndexBufferStride;

    [NativeTypeName("VkDeviceAddress")]
    public ulong IndexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong VertexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong GeometryIndexAndFlagsBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong OpacityMicromapArray;

    [NativeTypeName("VkDeviceAddress")]
    public ulong OpacityMicromapIndexBuffer;

    [NativeTypeName("VkDeviceAddress")]
    public ulong InstantiationBoundingBoxLimit;
}
