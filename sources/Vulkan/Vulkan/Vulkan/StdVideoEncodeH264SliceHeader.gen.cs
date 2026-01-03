// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoEncodeH264SliceHeader
{
    public StdVideoEncodeH264SliceHeaderFlags Flags;

    [NativeTypeName("uint32_t")]
    public uint FirstMbInSlice;
    public StdVideoH264SliceType SliceType;

    [NativeTypeName("int8_t")]
    public sbyte SliceAlphaC0OffsetDiv2;

    [NativeTypeName("int8_t")]
    public sbyte SliceBetaOffsetDiv2;

    [NativeTypeName("int8_t")]
    public sbyte SliceQpDelta;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;
    public StdVideoH264CabacInitIdc CabacInitIdc;
    public StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc;

    [NativeTypeName("const StdVideoEncodeH264WeightTable *")]
    public StdVideoEncodeH264WeightTable* PWeightTable;
}
