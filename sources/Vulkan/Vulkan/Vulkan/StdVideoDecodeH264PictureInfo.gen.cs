// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoDecodeH264PictureInfo
{
    public StdVideoDecodeH264PictureInfoFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte SeqParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte PicParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    public byte Reserved2;

    [NativeTypeName("uint16_t")]
    public ushort FrameNum;

    [NativeTypeName("uint16_t")]
    public ushort IdrPicId;

    [NativeTypeName("int32_t[2]")]
    public StdVideoDecodeH264PictureInfoPicOrderCnt PicOrderCnt;
}
