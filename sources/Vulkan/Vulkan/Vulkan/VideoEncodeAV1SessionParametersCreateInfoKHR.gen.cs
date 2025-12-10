// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeAV1SessionParametersCreateInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("const StdVideoAV1SequenceHeader *")]
    public StdVideoAV1SequenceHeader* PStdSequenceHeader;

    [NativeTypeName("const StdVideoEncodeAV1DecoderModelInfo *")]
    public StdVideoEncodeAV1DecoderModelInfo* PStdDecoderModelInfo;

    [NativeTypeName("uint32_t")]
    public uint StdOperatingPointCount;

    [NativeTypeName("const StdVideoEncodeAV1OperatingPointInfo *")]
    public StdVideoEncodeAV1OperatingPointInfo* PStdOperatingPoints;
}
