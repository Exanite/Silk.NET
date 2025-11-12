// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeAV1SessionParametersCreateInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("const StdVideoAV1SequenceHeader *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1SequenceHeader* PStdSequenceHeader;

    [NativeTypeName("const StdVideoEncodeAV1DecoderModelInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1DecoderModelInfo* PStdDecoderModelInfo;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint StdOperatingPointCount;

    [NativeTypeName("const StdVideoEncodeAV1OperatingPointInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1OperatingPointInfo* PStdOperatingPoints;
}
