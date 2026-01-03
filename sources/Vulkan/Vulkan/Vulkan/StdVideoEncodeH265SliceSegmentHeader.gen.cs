// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoEncodeH265SliceSegmentHeader
{
    public StdVideoEncodeH265SliceSegmentHeaderFlags Flags;
    public StdVideoH265SliceType SliceType;

    [NativeTypeName("uint32_t")]
    public uint SliceSegmentAddress;

    [NativeTypeName("uint8_t")]
    public byte CollocatedRefIdx;

    [NativeTypeName("uint8_t")]
    public byte MaxNumMergeCand;

    [NativeTypeName("int8_t")]
    public sbyte SliceCbQpOffset;

    [NativeTypeName("int8_t")]
    public sbyte SliceCrQpOffset;

    [NativeTypeName("int8_t")]
    public sbyte SliceBetaOffsetDiv2;

    [NativeTypeName("int8_t")]
    public sbyte SliceTcOffsetDiv2;

    [NativeTypeName("int8_t")]
    public sbyte SliceActYQpOffset;

    [NativeTypeName("int8_t")]
    public sbyte SliceActCbQpOffset;

    [NativeTypeName("int8_t")]
    public sbyte SliceActCrQpOffset;

    [NativeTypeName("int8_t")]
    public sbyte SliceQpDelta;

    [NativeTypeName("uint16_t")]
    public ushort Reserved1;

    [NativeTypeName("const StdVideoEncodeH265WeightTable *")]
    public StdVideoEncodeH265WeightTable* PWeightTable;
}
