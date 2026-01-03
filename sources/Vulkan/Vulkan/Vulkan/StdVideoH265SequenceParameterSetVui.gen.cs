// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoH265SequenceParameterSetVui
{
    public StdVideoH265SpsVuiFlags Flags;
    public StdVideoH265AspectRatioIdc AspectRatioIdc;

    [NativeTypeName("uint16_t")]
    public ushort SarWidth;

    [NativeTypeName("uint16_t")]
    public ushort SarHeight;

    [NativeTypeName("uint8_t")]
    public byte VideoFormat;

    [NativeTypeName("uint8_t")]
    public byte ColourPrimaries;

    [NativeTypeName("uint8_t")]
    public byte TransferCharacteristics;

    [NativeTypeName("uint8_t")]
    public byte MatrixCoeffs;

    [NativeTypeName("uint8_t")]
    public byte ChromaSampleLocTypeTopField;

    [NativeTypeName("uint8_t")]
    public byte ChromaSampleLocTypeBottomField;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    public byte Reserved2;

    [NativeTypeName("uint16_t")]
    public ushort DefDispWinLeftOffset;

    [NativeTypeName("uint16_t")]
    public ushort DefDispWinRightOffset;

    [NativeTypeName("uint16_t")]
    public ushort DefDispWinTopOffset;

    [NativeTypeName("uint16_t")]
    public ushort DefDispWinBottomOffset;

    [NativeTypeName("uint32_t")]
    public uint VuiNumUnitsInTick;

    [NativeTypeName("uint32_t")]
    public uint VuiTimeScale;

    [NativeTypeName("uint32_t")]
    public uint VuiNumTicksPocDiffOneMinus1;

    [NativeTypeName("uint16_t")]
    public ushort MinSpatialSegmentationIdc;

    [NativeTypeName("uint16_t")]
    public ushort Reserved3;

    [NativeTypeName("uint8_t")]
    public byte MaxBytesPerPicDenom;

    [NativeTypeName("uint8_t")]
    public byte MaxBitsPerMinCuDenom;

    [NativeTypeName("uint8_t")]
    public byte Log2MaxMvLengthHorizontal;

    [NativeTypeName("uint8_t")]
    public byte Log2MaxMvLengthVertical;

    [NativeTypeName("const StdVideoH265HrdParameters *")]
    public StdVideoH265HrdParameters* PHrdParameters;
}
