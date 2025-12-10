// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeH265CapabilitiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkVideoEncodeH265CapabilityFlagsKHR")]
    public VideoEncodeH265CapabilityFlagsKHR Flags;
    public StdVideoH265LevelIdc MaxLevelIdc;

    [NativeTypeName("uint32_t")]
    public uint MaxSliceSegmentCount;
    public Extent2D MaxTiles;

    [NativeTypeName("VkVideoEncodeH265CtbSizeFlagsKHR")]
    public VideoEncodeH265CtbSizeFlagsKHR CtbSizes;

    [NativeTypeName("VkVideoEncodeH265TransformBlockSizeFlagsKHR")]
    public VideoEncodeH265TransformBlockSizeFlagsKHR TransformBlockSizes;

    [NativeTypeName("uint32_t")]
    public uint MaxPPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint MaxBPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint MaxL1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint MaxSubLayerCount;

    [NativeTypeName("VkBool32")]
    public uint ExpectDyadicTemporalSubLayerPattern;

    [NativeTypeName("int32_t")]
    public int MinQp;

    [NativeTypeName("int32_t")]
    public int MaxQp;

    [NativeTypeName("VkBool32")]
    public uint PrefersGopRemainingFrames;

    [NativeTypeName("VkBool32")]
    public uint RequiresGopRemainingFrames;

    [NativeTypeName("VkVideoEncodeH265StdFlagsKHR")]
    public VideoEncodeH265StdFlagsKHR StdSyntaxFlags;
}
