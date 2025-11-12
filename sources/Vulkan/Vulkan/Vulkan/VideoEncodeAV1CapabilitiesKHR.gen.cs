// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeAV1CapabilitiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeAV1CapabilityFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1CapabilityFlagsKHR Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1Level MaxLevel;

    [SupportedApiProfile("vulkan")]
    public Extent2D CodedPictureAlignment;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxTiles;

    [SupportedApiProfile("vulkan")]
    public Extent2D MinTileSize;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxTileSize;

    [NativeTypeName("VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1SuperblockSizeFlagsKHR SuperblockSizes;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxSingleReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SingleReferenceNameMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxUnidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint UnidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxBidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint BidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTemporalLayerCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxSpatialLayerCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxOperatingPoints;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinQIndex;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxQIndex;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrefersGopRemainingFrames;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> RequiresGopRemainingFrames;

    [NativeTypeName("VkVideoEncodeAV1StdFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1StdFlagsKHR StdSyntaxFlags;
}
