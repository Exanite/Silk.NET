// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoDecodeVP9PictureInfo
{
    public StdVideoDecodeVP9PictureInfoFlags Flags;
    public StdVideoVP9Profile Profile;
    public StdVideoVP9FrameType FrameType;

    [NativeTypeName("uint8_t")]
    public byte FrameContextIdx;

    [NativeTypeName("uint8_t")]
    public byte ResetFrameContext;

    [NativeTypeName("uint8_t")]
    public byte RefreshFrameFlags;

    [NativeTypeName("uint8_t")]
    public byte RefFrameSignBiasMask;
    public StdVideoVP9InterpolationFilter InterpolationFilter;

    [NativeTypeName("uint8_t")]
    public byte BaseQIdx;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQYDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQUvDc;

    [NativeTypeName("int8_t")]
    public sbyte DeltaQUvAc;

    [NativeTypeName("uint8_t")]
    public byte TileColsLog2;

    [NativeTypeName("uint8_t")]
    public byte TileRowsLog2;

    [NativeTypeName("uint16_t[3]")]
    public StdVideoDecodeVP9PictureInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoVP9ColorConfig *")]
    public StdVideoVP9ColorConfig* PColorConfig;

    [NativeTypeName("const StdVideoVP9LoopFilter *")]
    public StdVideoVP9LoopFilter* PLoopFilter;

    [NativeTypeName("const StdVideoVP9Segmentation *")]
    public StdVideoVP9Segmentation* PSegmentation;
}
