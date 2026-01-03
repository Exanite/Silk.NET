// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeAV1CapabilitiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkVideoEncodeAV1CapabilityFlagsKHR")]
    public VideoEncodeAV1CapabilityFlagsKHR Flags;
    public StdVideoAV1Level MaxLevel;
    public Extent2D CodedPictureAlignment;
    public Extent2D MaxTiles;
    public Extent2D MinTileSize;
    public Extent2D MaxTileSize;

    [NativeTypeName("VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
    public VideoEncodeAV1SuperblockSizeFlagsKHR SuperblockSizes;

    [NativeTypeName("uint32_t")]
    public uint MaxSingleReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint SingleReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint MaxUnidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint MaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint UnidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint MaxBidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint MaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint MaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint BidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint MaxTemporalLayerCount;

    [NativeTypeName("uint32_t")]
    public uint MaxSpatialLayerCount;

    [NativeTypeName("uint32_t")]
    public uint MaxOperatingPoints;

    [NativeTypeName("uint32_t")]
    public uint MinQIndex;

    [NativeTypeName("uint32_t")]
    public uint MaxQIndex;

    [NativeTypeName("VkBool32")]
    public uint PrefersGopRemainingFrames;

    [NativeTypeName("VkBool32")]
    public uint RequiresGopRemainingFrames;

    [NativeTypeName("VkVideoEncodeAV1StdFlagsKHR")]
    public VideoEncodeAV1StdFlagsKHR StdSyntaxFlags;
}
