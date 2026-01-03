// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoH264PictureParameterSet
{
    public StdVideoH264PpsFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte SeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PicParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL0DefaultActiveMinus1;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL1DefaultActiveMinus1;
    public StdVideoH264WeightedBipredIdc WeightedBipredIdc;

    [NativeTypeName("int8_t")]
    public sbyte PicInitQpMinus26;

    [NativeTypeName("int8_t")]
    public sbyte PicInitQsMinus26;

    [NativeTypeName("int8_t")]
    public sbyte ChromaQpIndexOffset;

    [NativeTypeName("int8_t")]
    public sbyte SecondChromaQpIndexOffset;

    [NativeTypeName("const StdVideoH264ScalingLists *")]
    public StdVideoH264ScalingLists* PScalingLists;
}
