// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeH265QualityLevelPropertiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkVideoEncodeH265RateControlFlagsKHR")]
    public VideoEncodeH265RateControlFlagsKHR PreferredRateControlFlags;

    [NativeTypeName("uint32_t")]
    public uint PreferredGopFrameCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredIdrPeriod;

    [NativeTypeName("uint32_t")]
    public uint PreferredConsecutiveBFrameCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredSubLayerCount;
    public VideoEncodeH265QpKHR PreferredConstantQp;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxL0ReferenceCount;

    [NativeTypeName("uint32_t")]
    public uint PreferredMaxL1ReferenceCount;
}
