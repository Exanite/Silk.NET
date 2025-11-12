// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeAV1QualityLevelPropertiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeAV1RateControlFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1RateControlFlagsKHR PreferredRateControlFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredGopFrameCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredKeyFramePeriod;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredConsecutiveBipredictiveFrameCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredTemporalLayerCount;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1QIndexKHR PreferredConstantQIndex;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxSingleReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredSingleReferenceNameMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxUnidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredUnidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxBidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredBidirectionalCompoundReferenceNameMask;
}
