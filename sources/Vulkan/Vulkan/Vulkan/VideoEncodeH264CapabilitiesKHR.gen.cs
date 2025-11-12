// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeH264CapabilitiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeH264CapabilityFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeH264CapabilityFlagsKHR Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoH264LevelIdc MaxLevelIdc;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxSliceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxBPictureL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxL1ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTemporalLayerCount;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ExpectDyadicTemporalLayerPattern;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int MinQp;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int MaxQp;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrefersGopRemainingFrames;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> RequiresGopRemainingFrames;

    [NativeTypeName("VkVideoEncodeH264StdFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeH264StdFlagsKHR StdSyntaxFlags;
}
