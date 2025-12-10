// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoEncodeH265WeightTable
{
    public StdVideoEncodeH265WeightTableFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte LumaLog2WeightDenom;

    [NativeTypeName("int8_t")]
    public sbyte DeltaChromaLog2WeightDenom;

    [NativeTypeName("int8_t[15]")]
    public StdVideoEncodeH265WeightTableDeltaLumaWeightL0 DeltaLumaWeightL0;

    [NativeTypeName("int8_t[15]")]
    public StdVideoEncodeH265WeightTableLumaOffsetL0 LumaOffsetL0;

    [NativeTypeName("int8_t[15][2]")]
    public StdVideoEncodeH265WeightTableDeltaChromaWeightL0 DeltaChromaWeightL0;

    [NativeTypeName("int8_t[15][2]")]
    public StdVideoEncodeH265WeightTableDeltaChromaOffsetL0 DeltaChromaOffsetL0;

    [NativeTypeName("int8_t[15]")]
    public StdVideoEncodeH265WeightTableDeltaLumaWeightL1 DeltaLumaWeightL1;

    [NativeTypeName("int8_t[15]")]
    public StdVideoEncodeH265WeightTableLumaOffsetL1 LumaOffsetL1;

    [NativeTypeName("int8_t[15][2]")]
    public StdVideoEncodeH265WeightTableDeltaChromaWeightL1 DeltaChromaWeightL1;

    [NativeTypeName("int8_t[15][2]")]
    public StdVideoEncodeH265WeightTableDeltaChromaOffsetL1 DeltaChromaOffsetL1;
}
