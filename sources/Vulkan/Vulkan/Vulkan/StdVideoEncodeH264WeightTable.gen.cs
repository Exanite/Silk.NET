// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoEncodeH264WeightTable
{
    public StdVideoEncodeH264WeightTableFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte LumaLog2WeightDenom;

    [NativeTypeName("uint8_t")]
    public byte ChromaLog2WeightDenom;

    [NativeTypeName("int8_t[32]")]
    public StdVideoEncodeH264WeightTableLumaWeightL0 LumaWeightL0;

    [NativeTypeName("int8_t[32]")]
    public StdVideoEncodeH264WeightTableLumaOffsetL0 LumaOffsetL0;

    [NativeTypeName("int8_t[32][2]")]
    public StdVideoEncodeH264WeightTableChromaWeightL0 ChromaWeightL0;

    [NativeTypeName("int8_t[32][2]")]
    public StdVideoEncodeH264WeightTableChromaOffsetL0 ChromaOffsetL0;

    [NativeTypeName("int8_t[32]")]
    public StdVideoEncodeH264WeightTableLumaWeightL1 LumaWeightL1;

    [NativeTypeName("int8_t[32]")]
    public StdVideoEncodeH264WeightTableLumaOffsetL1 LumaOffsetL1;

    [NativeTypeName("int8_t[32][2]")]
    public StdVideoEncodeH264WeightTableChromaWeightL1 ChromaWeightL1;

    [NativeTypeName("int8_t[32][2]")]
    public StdVideoEncodeH264WeightTableChromaOffsetL1 ChromaOffsetL1;
}
