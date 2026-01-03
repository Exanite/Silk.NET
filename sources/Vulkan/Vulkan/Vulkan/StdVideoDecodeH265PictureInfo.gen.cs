// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoDecodeH265PictureInfo
{
    public StdVideoDecodeH265PictureInfoFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte SpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PpsSeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PpsPicParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte NumDeltaPocsOfRefRpsIdx;

    [NativeTypeName("int32_t")]
    public int PicOrderCntVal;

    [NativeTypeName("uint16_t")]
    public ushort NumBitsForSTRefPicSetInSlice;

    [NativeTypeName("uint16_t")]
    public ushort Reserved;

    [NativeTypeName("uint8_t[8]")]
    public StdVideoDecodeH265PictureInfoRefPicSetStCurrBefore RefPicSetStCurrBefore;

    [NativeTypeName("uint8_t[8]")]
    public StdVideoDecodeH265PictureInfoRefPicSetStCurrAfter RefPicSetStCurrAfter;

    [NativeTypeName("uint8_t[8]")]
    public StdVideoDecodeH265PictureInfoRefPicSetLtCurr RefPicSetLtCurr;
}
