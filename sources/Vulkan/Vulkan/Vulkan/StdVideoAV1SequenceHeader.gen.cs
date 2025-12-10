// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoAV1SequenceHeader
{
    public StdVideoAV1SequenceHeaderFlags Flags;
    public StdVideoAV1Profile SeqProfile;

    [NativeTypeName("uint8_t")]
    public byte FrameWidthBitsMinus1;

    [NativeTypeName("uint8_t")]
    public byte FrameHeightBitsMinus1;

    [NativeTypeName("uint16_t")]
    public ushort MaxFrameWidthMinus1;

    [NativeTypeName("uint16_t")]
    public ushort MaxFrameHeightMinus1;

    [NativeTypeName("uint8_t")]
    public byte DeltaFrameIdLengthMinus2;

    [NativeTypeName("uint8_t")]
    public byte AdditionalFrameIdLengthMinus1;

    [NativeTypeName("uint8_t")]
    public byte OrderHintBitsMinus1;

    [NativeTypeName("uint8_t")]
    public byte SeqForceIntegerMv;

    [NativeTypeName("uint8_t")]
    public byte SeqForceScreenContentTools;

    [NativeTypeName("uint8_t[5]")]
    public StdVideoAV1SequenceHeaderReserved1 Reserved1;

    [NativeTypeName("const StdVideoAV1ColorConfig *")]
    public StdVideoAV1ColorConfig* PColorConfig;

    [NativeTypeName("const StdVideoAV1TimingInfo *")]
    public StdVideoAV1TimingInfo* PTimingInfo;
}
