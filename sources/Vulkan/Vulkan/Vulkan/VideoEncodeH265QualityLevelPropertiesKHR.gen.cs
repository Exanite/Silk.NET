// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeH265QualityLevelPropertiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeH265RateControlFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeH265RateControlFlagsKHR PreferredRateControlFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredGopFrameCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredIdrPeriod;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredConsecutiveBFrameCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredSubLayerCount;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeH265QpKHR PreferredConstantQp;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreferredMaxL1ReferenceCount;
}
