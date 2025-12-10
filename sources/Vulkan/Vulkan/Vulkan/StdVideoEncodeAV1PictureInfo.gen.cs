// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoEncodeAV1PictureInfo
{
    public StdVideoEncodeAV1PictureInfoFlags Flags;
    public StdVideoAV1FrameType FrameType;

    [NativeTypeName("uint32_t")]
    public uint FramePresentationTime;

    [NativeTypeName("uint32_t")]
    public uint CurrentFrameId;

    [NativeTypeName("uint8_t")]
    public byte OrderHint;

    [NativeTypeName("uint8_t")]
    public byte PrimaryRefFrame;

    [NativeTypeName("uint8_t")]
    public byte RefreshFrameFlags;

    [NativeTypeName("uint8_t")]
    public byte CodedDenom;

    [NativeTypeName("uint16_t")]
    public ushort RenderWidthMinus1;

    [NativeTypeName("uint16_t")]
    public ushort RenderHeightMinus1;
    public StdVideoAV1InterpolationFilter InterpolationFilter;
    public StdVideoAV1TxMode TxMode;

    [NativeTypeName("uint8_t")]
    public byte DeltaQRes;

    [NativeTypeName("uint8_t")]
    public byte DeltaLfRes;

    [NativeTypeName("uint8_t[8]")]
    public StdVideoEncodeAV1PictureInfoRefOrderHint RefOrderHint;

    [NativeTypeName("int8_t[7]")]
    public StdVideoEncodeAV1PictureInfoRefFrameIdx RefFrameIdx;

    [NativeTypeName("uint8_t[3]")]
    public StdVideoEncodeAV1PictureInfoReserved1 Reserved1;

    [NativeTypeName("uint32_t[7]")]
    public StdVideoEncodeAV1PictureInfoDeltaFrameIdMinus1 DeltaFrameIdMinus1;

    [NativeTypeName("const StdVideoAV1TileInfo *")]
    public StdVideoAV1TileInfo* PTileInfo;

    [NativeTypeName("const StdVideoAV1Quantization *")]
    public StdVideoAV1Quantization* PQuantization;

    [NativeTypeName("const StdVideoAV1Segmentation *")]
    public StdVideoAV1Segmentation* PSegmentation;

    [NativeTypeName("const StdVideoAV1LoopFilter *")]
    public StdVideoAV1LoopFilter* PLoopFilter;

    [NativeTypeName("const StdVideoAV1CDEF *")]
    public StdVideoAV1CDEF* Pcdef;

    [NativeTypeName("const StdVideoAV1LoopRestoration *")]
    public StdVideoAV1LoopRestoration* PLoopRestoration;

    [NativeTypeName("const StdVideoAV1GlobalMotion *")]
    public StdVideoAV1GlobalMotion* PGlobalMotion;

    [NativeTypeName("const StdVideoEncodeAV1ExtensionHeader *")]
    public StdVideoEncodeAV1ExtensionHeader* PExtensionHeader;

    [NativeTypeName("const uint32_t *")]
    public uint* PBufferRemovalTimes;
}
