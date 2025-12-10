// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoH265PictureParameterSet
{
    public StdVideoH265PpsFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte PpsPicParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PpsSeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte SpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte NumExtraSliceHeaderBits;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL0DefaultActiveMinus1;

    [NativeTypeName("uint8_t")]
    public byte NumRefIdxL1DefaultActiveMinus1;

    [NativeTypeName("int8_t")]
    public sbyte InitQpMinus26;

    [NativeTypeName("uint8_t")]
    public byte DiffCuQpDeltaDepth;

    [NativeTypeName("int8_t")]
    public sbyte PpsCbQpOffset;

    [NativeTypeName("int8_t")]
    public sbyte PpsCrQpOffset;

    [NativeTypeName("int8_t")]
    public sbyte PpsBetaOffsetDiv2;

    [NativeTypeName("int8_t")]
    public sbyte PpsTcOffsetDiv2;

    [NativeTypeName("uint8_t")]
    public byte Log2ParallelMergeLevelMinus2;

    [NativeTypeName("uint8_t")]
    public byte Log2MaxTransformSkipBlockSizeMinus2;

    [NativeTypeName("uint8_t")]
    public byte DiffCuChromaQpOffsetDepth;

    [NativeTypeName("uint8_t")]
    public byte ChromaQpOffsetListLenMinus1;

    [NativeTypeName("int8_t[6]")]
    public StdVideoH265PictureParameterSetCbQpOffsetList CbQpOffsetList;

    [NativeTypeName("int8_t[6]")]
    public StdVideoH265PictureParameterSetCrQpOffsetList CrQpOffsetList;

    [NativeTypeName("uint8_t")]
    public byte Log2SaoOffsetScaleLuma;

    [NativeTypeName("uint8_t")]
    public byte Log2SaoOffsetScaleChroma;

    [NativeTypeName("int8_t")]
    public sbyte PpsActYQpOffsetPlus5;

    [NativeTypeName("int8_t")]
    public sbyte PpsActCbQpOffsetPlus5;

    [NativeTypeName("int8_t")]
    public sbyte PpsActCrQpOffsetPlus3;

    [NativeTypeName("uint8_t")]
    public byte PpsNumPalettePredictorInitializers;

    [NativeTypeName("uint8_t")]
    public byte LumaBitDepthEntryMinus8;

    [NativeTypeName("uint8_t")]
    public byte ChromaBitDepthEntryMinus8;

    [NativeTypeName("uint8_t")]
    public byte NumTileColumnsMinus1;

    [NativeTypeName("uint8_t")]
    public byte NumTileRowsMinus1;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    public byte Reserved2;

    [NativeTypeName("uint16_t[19]")]
    public StdVideoH265PictureParameterSetColumnWidthMinus1 ColumnWidthMinus1;

    [NativeTypeName("uint16_t[21]")]
    public StdVideoH265PictureParameterSetRowHeightMinus1 RowHeightMinus1;

    [NativeTypeName("uint32_t")]
    public uint Reserved3;

    [NativeTypeName("const StdVideoH265ScalingLists *")]
    public StdVideoH265ScalingLists* PScalingLists;

    [NativeTypeName("const StdVideoH265PredictorPaletteEntries *")]
    public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
}
