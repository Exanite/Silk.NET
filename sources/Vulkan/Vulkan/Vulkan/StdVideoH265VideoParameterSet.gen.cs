// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoH265VideoParameterSet
{
    public StdVideoH265VpsFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte VpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    public byte VpsMaxSubLayersMinus1;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    public byte Reserved2;

    [NativeTypeName("uint32_t")]
    public uint VpsNumUnitsInTick;

    [NativeTypeName("uint32_t")]
    public uint VpsTimeScale;

    [NativeTypeName("uint32_t")]
    public uint VpsNumTicksPocDiffOneMinus1;

    [NativeTypeName("uint32_t")]
    public uint Reserved3;

    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeTypeName("const StdVideoH265HrdParameters *")]
    public StdVideoH265HrdParameters* PHrdParameters;

    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;
}
