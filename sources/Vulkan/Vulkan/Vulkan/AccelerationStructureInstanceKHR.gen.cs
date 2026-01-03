// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct AccelerationStructureInstanceKHR
{
    public TransformMatrixKHR Transform;
    public uint Bitfield1;

    [NativeTypeName("uint32_t : 24")]
    public uint InstanceCustomIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield1 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield1 = (Bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("uint32_t : 8")]
    public uint Mask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield1 >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield1 = (Bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }
    public uint Bitfield2;

    [NativeTypeName("uint32_t : 24")]
    public uint InstanceShaderBindingTableRecordOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield2 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield2 = (Bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeTypeName("VkGeometryInstanceFlagsKHR : 8")]
    public GeometryInstanceFlagsKHR Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (GeometryInstanceFlagsKHR)((Bitfield2 >> 24) & 0xFFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield2 = (Bitfield2 & ~(0xFFu << 24)) | (((uint)(value) & 0xFFu) << 24); }
    }

    [NativeTypeName("uint64_t")]
    public ulong AccelerationStructureReference;
}
