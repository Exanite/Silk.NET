// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoH264SequenceParameterSet
{
    public StdVideoH264SpsFlags Flags;
    public StdVideoH264ProfileIdc ProfileIdc;
    public StdVideoH264LevelIdc LevelIdc;
    public StdVideoH264ChromaFormatIdc ChromaFormatIdc;

    [NativeTypeName("uint8_t")]
    public byte SeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte BitDepthLumaMinus8;

    [NativeTypeName("uint8_t")]
    public byte BitDepthChromaMinus8;

    [NativeTypeName("uint8_t")]
    public byte Log2MaxFrameNumMinus4;
    public StdVideoH264PocType PicOrderCntType;

    [NativeTypeName("int32_t")]
    public int OffsetForNonRefPic;

    [NativeTypeName("int32_t")]
    public int OffsetForTopToBottomField;

    [NativeTypeName("uint8_t")]
    public byte Log2MaxPicOrderCntLsbMinus4;

    [NativeTypeName("uint8_t")]
    public byte NumRefFramesInPicOrderCntCycle;

    [NativeTypeName("uint8_t")]
    public byte MaxNumRefFrames;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;

    [NativeTypeName("uint32_t")]
    public uint PicWidthInMbsMinus1;

    [NativeTypeName("uint32_t")]
    public uint PicHeightInMapUnitsMinus1;

    [NativeTypeName("uint32_t")]
    public uint FrameCropLeftOffset;

    [NativeTypeName("uint32_t")]
    public uint FrameCropRightOffset;

    [NativeTypeName("uint32_t")]
    public uint FrameCropTopOffset;

    [NativeTypeName("uint32_t")]
    public uint FrameCropBottomOffset;

    [NativeTypeName("uint32_t")]
    public uint Reserved2;

    [NativeTypeName("const int32_t *")]
    public int* POffsetForRefFrame;

    [NativeTypeName("const StdVideoH264ScalingLists *")]
    public StdVideoH264ScalingLists* PScalingLists;

    [NativeTypeName("const StdVideoH264SequenceParameterSetVui *")]
    public StdVideoH264SequenceParameterSetVui* PSequenceParameterSetVui;
}
