// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoH265SequenceParameterSet
{
    public StdVideoH265SpsFlags Flags;
    public StdVideoH265ChromaFormatIdc ChromaFormatIdc;

    [NativeTypeName("uint32_t")]
    public uint PicWidthInLumaSamples;

    [NativeTypeName("uint32_t")]
    public uint PicHeightInLumaSamples;

    [NativeTypeName("uint8_t")]
    public byte SpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte SpsMaxSubLayersMinus1;

    [NativeTypeName("uint8_t")]
    public byte SpsSeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte BitDepthLumaMinus8;

    [NativeTypeName("uint8_t")]
    public byte BitDepthChromaMinus8;

    [NativeTypeName("uint8_t")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeTypeName("uint8_t")]
    public byte Log2MinLumaCodingBlockSizeMinus3;

    [NativeTypeName("uint8_t")]
    public byte Log2DiffMaxMinLumaCodingBlockSize;

    [NativeTypeName("uint8_t")]
    public byte Log2MinLumaTransformBlockSizeMinus2;

    [NativeTypeName("uint8_t")]
    public byte Log2DiffMaxMinLumaTransformBlockSize;

    [NativeTypeName("uint8_t")]
    public byte MaxTransformHierarchyDepthInter;

    [NativeTypeName("uint8_t")]
    public byte MaxTransformHierarchyDepthIntra;

    [NativeTypeName("uint8_t")]
    public byte NumShortTermRefPicSets;

    [NativeTypeName("uint8_t")]
    public byte NumLongTermRefPicsSps;

    [NativeTypeName("uint8_t")]
    public byte PcmSampleBitDepthLumaMinus1;

    [NativeTypeName("uint8_t")]
    public byte PcmSampleBitDepthChromaMinus1;

    [NativeTypeName("uint8_t")]
    public byte Log2MinPcmLumaCodingBlockSizeMinus3;

    [NativeTypeName("uint8_t")]
    public byte Log2DiffMaxMinPcmLumaCodingBlockSize;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    public byte Reserved2;

    [NativeTypeName("uint8_t")]
    public byte PaletteMaxSize;

    [NativeTypeName("uint8_t")]
    public byte DeltaPaletteMaxPredictorSize;

    [NativeTypeName("uint8_t")]
    public byte MotionVectorResolutionControlIdc;

    [NativeTypeName("uint8_t")]
    public byte SpsNumPalettePredictorInitializersMinus1;

    [NativeTypeName("uint32_t")]
    public uint ConfWinLeftOffset;

    [NativeTypeName("uint32_t")]
    public uint ConfWinRightOffset;

    [NativeTypeName("uint32_t")]
    public uint ConfWinTopOffset;

    [NativeTypeName("uint32_t")]
    public uint ConfWinBottomOffset;

    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;

    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeTypeName("const StdVideoH265ScalingLists *")]
    public StdVideoH265ScalingLists* PScalingLists;

    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeTypeName("const StdVideoH265LongTermRefPicsSps *")]
    public StdVideoH265LongTermRefPicsSps* PLongTermRefPicsSps;

    [NativeTypeName("const StdVideoH265SequenceParameterSetVui *")]
    public StdVideoH265SequenceParameterSetVui* PSequenceParameterSetVui;

    [NativeTypeName("const StdVideoH265PredictorPaletteEntries *")]
    public StdVideoH265PredictorPaletteEntries* PPredictorPaletteEntries;
}
