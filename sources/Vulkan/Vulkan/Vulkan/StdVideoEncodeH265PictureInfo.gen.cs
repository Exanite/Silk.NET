// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoEncodeH265PictureInfo
{
    public StdVideoEncodeH265PictureInfoFlags Flags;
    public StdVideoH265PictureType PicType;

    [NativeTypeName("uint8_t")]
    public byte SpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PpsSeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PpsPicParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte ShortTermRefPicSetIdx;

    [NativeTypeName("int32_t")]
    public int PicOrderCntVal;

    [NativeTypeName("uint8_t")]
    public byte TemporalId;

    [NativeTypeName("uint8_t[7]")]
    public StdVideoEncodeH265PictureInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoEncodeH265ReferenceListsInfo *")]
    public StdVideoEncodeH265ReferenceListsInfo* PRefLists;

    [NativeTypeName("const StdVideoH265ShortTermRefPicSet *")]
    public StdVideoH265ShortTermRefPicSet* PShortTermRefPicSet;

    [NativeTypeName("const StdVideoEncodeH265LongTermRefPics *")]
    public StdVideoEncodeH265LongTermRefPics* PLongTermRefPics;
}
