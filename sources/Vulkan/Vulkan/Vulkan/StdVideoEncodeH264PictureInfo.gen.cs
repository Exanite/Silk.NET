// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoEncodeH264PictureInfo
{
    public StdVideoEncodeH264PictureInfoFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte SeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PicParameterSetId;

    [NativeTypeName("uint16_t")]
    public ushort IdrPicId;
    public StdVideoH264PictureType PrimaryPicType;

    [NativeTypeName("uint32_t")]
    public uint FrameNum;

    [NativeTypeName("int32_t")]
    public int PicOrderCnt;

    [NativeTypeName("uint8_t")]
    public byte TemporalId;

    [NativeTypeName("uint8_t[3]")]
    public StdVideoEncodeH264PictureInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoEncodeH264ReferenceListsInfo *")]
    public StdVideoEncodeH264ReferenceListsInfo* PRefLists;
}
