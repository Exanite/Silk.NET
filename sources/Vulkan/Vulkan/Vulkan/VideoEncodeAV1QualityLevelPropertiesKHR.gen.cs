// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeAV1QualityLevelPropertiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkVideoEncodeAV1RateControlFlagsKHR")]
    public VideoEncodeAV1RateControlFlagsKHR PreferredRateControlFlags;

    [NativeTypeName("uint32_t")]
    public uint PreferredGopFrameCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredKeyFramePeriod;

    [NativeTypeName("uint32_t")]
    public uint PreferredConsecutiveBipredictiveFrameCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredTemporalLayerCount;
    public VideoEncodeAV1QIndexKHR PreferredConstantQIndex;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxSingleReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredSingleReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxUnidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredUnidirectionalCompoundReferenceNameMask;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxBidirectionalCompoundReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredBidirectionalCompoundReferenceNameMask;
}
